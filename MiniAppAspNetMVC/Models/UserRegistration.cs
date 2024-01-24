using System.ComponentModel.DataAnnotations;

namespace MiniAppAspNetMVC.Models
{
    public class UserRegistration
    {
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Введите своё имя")]
        [StringLength(50)]
        [MinLength(2)]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [UIHint("EmailAdress")]
        [Required(ErrorMessage = "Введите свою почту")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage ="Не верный форма почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите свой пароль")]
        [Display(Name = "Пароль")]
        [UIHint("Password")]
        [Compare("ConfirmPassword", ErrorMessage = "Пароли не совпадают")]
        [StringLength(15,MinimumLength = 6, ErrorMessage ="Пароль должен быть от 6 до 15 символов")]
        public string Password { get; set; }

        [Display(Name = "Повторить пароль")]
        [UIHint("Password")]
        [Required(ErrorMessage = "Введите свой пароль")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Пароль должен быть от 6 до 15 символов")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Возраст")]
        [Range(18,100, ErrorMessage = "Возраст должен быть от 18 до 100")]
        public int? Age { get; set; }

        [Display(Name = "Согласны ли вы условиями соглашения?")]
        [Required(ErrorMessage = "Вы должны согласиться для продолжения")]
        public bool isAgree { get; set; }
    }
}
