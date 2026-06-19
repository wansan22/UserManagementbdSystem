using System.ComponentModel.DataAnnotations;
namespace UserManagement.Api
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно для заполнения.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Логин обязателен для заполнения.")]
        public string Login { get; set; } = string.Empty;
        [Required(ErrorMessage = "Пароль не может быть пустой ( null )")]
        [MinLength(6,ErrorMessage = "Пароль должен содержать минимум 6 символов")]
        public string Password { get; set; } = string.Empty;
    }
}