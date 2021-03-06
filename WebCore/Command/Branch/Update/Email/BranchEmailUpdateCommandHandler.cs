﻿using Data;
using Domain.Command;
using Domain.IServices;
using Infrastructure.Decorator;
using Infrastructure.Repository;
using System;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace WebCore.Command
{
    public class BranchEmailUpdateCommandHandler : ICommandHandler<BranchEmailUpdateCommand>
    {
        private readonly IActivityService iActivityServices;
        public BranchEmailUpdateCommandHandler(IActivityService _iActivityServices)
        {
            iActivityServices = _iActivityServices;
        }
        public void Handle(BranchEmailUpdateCommand command)
        {
            using (var uow = new UnitOfWork<EF>())
            {
                try
                {
                    //update
                    var branchEntity = uow.Repository<Branch>().GetById(p=>p.BranchId.Equals(command.BranchId)&& !p.DeletedDate.HasValue);
                    var previousVal = branchEntity.Email;
                    branchEntity.LastModifiedDate = System.DateTime.Now;
                    branchEntity.Email = command.Email;
                    uow.Repository<Branch>().Update(branchEntity);
                    uow.SubmitChanges();
                    //log
                    //Inset new Activity
                    var activity = new Activity()
                    {
                        Source = "Chi nhánh",
                        Source_Id = branchEntity.BranchId,
                        Action = "Sửa",
                        Previous_value = previousVal,
                        Current_value = command.Email,
                        CreatedDate = System.DateTime.Now,
                        CreatedBy = command.UserId
                    };
                    iActivityServices.AddActivity(new ActivityAddCommand { Activity = activity });
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                                    validationError.PropertyName,
                                                    validationError.ErrorMessage);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
          
        }
    }
}
