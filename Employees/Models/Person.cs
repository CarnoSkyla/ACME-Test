using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class Person
    {
        [Key]

        [Display(Name = "Person ID")]
        public int PersonId { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
    }
}
