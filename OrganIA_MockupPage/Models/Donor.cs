using System;
using System.ComponentModel.DataAnnotations;

namespace OrganIA_MockupPage.Models
{
    public class Donor
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
        public string Organ { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Rhesus { get; set; }
        [Required]
        public char RhesusSign { get; set; }
        [Required]
        public string HospitalFrom { get; set; }
        public string HospitalTo { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int BMI { get; set; }
        [Required]
        public int BloodIonogramForeignKey { get; set; }
        [Required]
        public int DonorForeignKey { get; set; }
    }
}