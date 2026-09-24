namespace SAPCrystalReports.BaseClasses.DTOs
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(int id, string login, string name, string password)
        {
            Id = id;
            Login = login;
            Name = name;
            Password = password;
        }

        public User()
        {
        }
    }
}
