//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class GD_DON_VI_PHAP_NHAN
    {
        public decimal ID { get; set; }
        public decimal ID_DON_VI { get; set; }
        public decimal ID_PHAP_NHAN { get; set; }
    
        public virtual DM_DON_VI DM_DON_VI { get; set; }
        public virtual DM_PHAP_NHAN DM_PHAP_NHAN { get; set; }
    }
}