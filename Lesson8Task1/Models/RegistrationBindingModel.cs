using Lesson8Task1.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Lesson8Task1.Models
{
    public class RegistrationBindingModel
    {
        [Required(ErrorMessage = "Введите вашу фамилию и имя")]
        [StringLength(50)]
        [Display(Name ="ФИО")]
        public string FIO { get; set; }
        [Required]
        [Display(Name = "Email")]
        [UIHint("EmailAddress")]
        public string Email { get; set; }
        [Required]
        [ValidationDate]
        [Display(Name = "Дата и время")]
        [UIHint("DateTime-local")]
        public DateTime Date { get; set; }
    }
}
