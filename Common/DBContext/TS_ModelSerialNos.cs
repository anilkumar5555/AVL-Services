//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class TS_ModelSerialNos
    {
        public int SerialID { get; set; }
        public Nullable<int> ModelId { get; set; }
        public string SerialNubmers { get; set; }
        public string HSNCode { get; set; }
        public string Capacity { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Color { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public string ACSerialNumbers { get; set; }
    
        public virtual TS_Users TS_Users { get; set; }
        public virtual TS_ProductModels TS_ProductModels { get; set; }
        public virtual TS_Users TS_Users1 { get; set; }
    }
}
