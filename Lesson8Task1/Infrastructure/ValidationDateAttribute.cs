using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson8Task1.Infrastructure
{
    public class ValidationDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime date)
            {
                if(date.Date <= DateTime.Now.Date)
                {
                    return new ValidationResult("Дата должна быть в будущем.");
                }

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    return new ValidationResult("Дата не может быть выходным днем.");
                }

                return ValidationResult.Success;
            }

            return new ValidationResult("Некорректный формат даты");
        }
    }
}
