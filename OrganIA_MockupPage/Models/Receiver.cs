using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganIA_MockupPage.Models
{
    public class Receiver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfArrival { get; set; }
        [Required]
        public string OrganToTransplant { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Rhesus { get; set; }
        [Required]
        public char RhesusSign { get; set; }
        public string HospitalFrom { get; set; }
        [Required]
        public string HospitalTo { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int BMI { get; set; }
        [Required]
        public int DonorKey { get; set; }
    }
}
