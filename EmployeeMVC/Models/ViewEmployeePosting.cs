//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewEmployeePosting
    {
        public int RowID { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string OfficeID { get; set; }
        public string OfficeName { get; set; }
        public string Department { get; set; }
        public string DepartmentName { get; set; }
        public string Remarks { get; set; }
        public string ReportingOfficerID { get; set; }
        public string ReportingOfficerName { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string CreatorName { get; set; }
    }
}
