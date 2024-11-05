using System.ComponentModel.DataAnnotations;

namespace ULO.UI.Models.Validation
{
    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is bool boolValue && boolValue;
        }
    }
}
