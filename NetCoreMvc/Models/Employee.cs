using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvc.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [DisplayName("Full Name")]
        public string FullName { get; set; }
        public string EmpCode { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
    }
}
