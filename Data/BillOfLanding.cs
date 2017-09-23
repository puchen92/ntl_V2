//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillOfLanding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillOfLanding()
        {
            this.Customers = new HashSet<Customer>();
            this.Branches = new HashSet<Branch>();
        }
    
        public int Id { get; set; }
        public string BolCode { get; set; }
        public Nullable<int> DeliveryType { get; set; }
        public Nullable<int> MerchandiseType { get; set; }
        public Nullable<int> StatusCode { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<System.DateTime> ReceiveTime { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public string SendAddress { get; set; }
        public string AdditionalFee { get; set; }
        public string Total { get; set; }
        public string Prepaid { get; set; }
        public string Liabilities { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string MixValue { get; set; }
        public string CollectInBehalf { get; set; }
        public string DeclareValue { get; set; }
        public Nullable<bool> IsGuarantee { get; set; }
        public Nullable<bool> IsOnHand { get; set; }
        public Nullable<int> Start { get; set; }
        public string Contact { get; set; }
    
        public virtual DeliveryType DeliveryType1 { get; set; }
        public virtual MerchandiseType MerchandiseType1 { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
