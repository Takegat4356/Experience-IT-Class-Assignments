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
    
    public partial class Employee
    {
        public Employee()
        {
            this.Hours = new HashSet<Hour>();
        }
    
        public int ID { get; set; }
        public int DeptID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime Birthday { get; set; }
        public string SSN { get; set; }
        public System.DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Hour> Hours { get; set; }
    }
}
