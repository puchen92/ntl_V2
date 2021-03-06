﻿using Domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IServices
{
    public interface IActivityService
    {
        /// <summary>
        /// Add new activity
        /// </summary>
        /// <param name="activity">Instance of activity</param>
        void AddActivity(ActivityAddCommand activity);
    }
}
