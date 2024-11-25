namespace TestApi4ITB_2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public User()
        {
            if (Name == null) Name = "";
            Email = Email ?? "";
            Password ??= "";
        }
    }
}
