namespace MiniAppAspNetMVC.Models
{
    public class UserRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Age { get; set; }
        public bool isAgree { get; set; }
    }
}
