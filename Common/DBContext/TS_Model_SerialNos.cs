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
    
    public partial class TS_Model_SerialNos
    {
        public int ModelSerilaNoId { get; set; }
        public Nullable<int> ProductModelId { get; set; }
        public string SerialNo { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual TS_Users TS_Users { get; set; }
        public virtual TS_Models TS_Models { get; set; }
        public virtual TS_Users TS_Users1 { get; set; }
    }
}
