//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayrollWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hour
    {
        public int ID { get; set; }
        public int EmpID { get; set; }
        public decimal Regular_Hours { get; set; }
        public decimal Overtime_Hours { get; set; }
        public decimal Holiday { get; set; }
        public decimal PTO { get; set; }
        public decimal Vacation { get; set; }
        public System.DateTime DateTime { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}