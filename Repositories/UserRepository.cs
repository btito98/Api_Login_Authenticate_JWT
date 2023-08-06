using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>()
            {
                new User { Id = 1, Username = "btito", Password = "btito", Role = "administrador" },
                new User { Id = 2, Username = "teste", Password = "teste", Role = "operador" }
            };
            return users
                .FirstOrDefault(x =>
                x.Username == username
                && x.Password == password);
                
        }
    }
}
