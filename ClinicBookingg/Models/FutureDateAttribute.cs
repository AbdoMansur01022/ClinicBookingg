using System.ComponentModel.DataAnnotations;

namespace ClinicBookingg.Attributes
{
    // Bonus 1: Custom Validation Attribute for Future Dates
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateTime)
            {
                return dateTime > DateTime.Now;
            }
            return true; // Allow nulls; use [Required] to enforce presence
        }

        public override string FormatErrorMessage(string name)
        {
            return ErrorMessage ?? $"{name} must be a date in the future.";
        }
    }
}