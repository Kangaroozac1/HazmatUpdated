using System.ComponentModel.DataAnnotations;

namespace Hazmat
{
    public class Login
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string ID { get; set; }
        public bool LoggedIn { get; set; }
    }
}