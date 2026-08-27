using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ClinicBookingg.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        // Q1, Q5: Name is required (3-50 chars)
        [Required(ErrorMessage = "Please enter the doctor's full name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Doctor name must be between 3 and 50 characters.")]
        public string Name { get; set; } = string.Empty;

        // Q7, Q12 Bonus 2: Licence Number with Remote Validation
        [Required(ErrorMessage = "Please enter the doctor's licence number.")]
        [Remote(action: "VerifyLicenceNumber", controller: "Doctors", AdditionalFields = "Id", ErrorMessage = "This licence number is already registered.")]
        [Display(Name = "Licence Number")]
        public string LicenceNumber { get; set; } = string.Empty;

        // Q1, Q5, Q6: Egyptian Mobile Number Regex
        [Required(ErrorMessage = "Please enter a phone number.")]
        [RegularExpression(@"^01[0125]\d{8}$", ErrorMessage = "Enter a valid Egyptian mobile number (e.g., 01012345678).")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = string.Empty;

        [Display(Name = "Specialty")]
        [Required(ErrorMessage = "Please select a specialty.")]
        public string Specialty { get; set; } = string.Empty;

        // Q1, Q5: Experience years (0-60)
        [Range(0, 60, ErrorMessage = "Years of experience must be between 0 and 60.")]
        [Display(Name = "Years of Experience")]
        public int YearsOfExperience { get; set; }

        public string? Bio { get; set; }

        // Q12: Image Filename
        [Display(Name = "Profile Photo")]
        public string? ImageUrl { get; set; }

        // Backward compatibility for existing properties
        public bool IsAcceptingPatients { get; set; } = true;
    }
}