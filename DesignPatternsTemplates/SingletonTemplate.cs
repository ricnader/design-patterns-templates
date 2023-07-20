using DesignPatternsTemplates.Factory;
using DesignPatternsTemplates.Models;

namespace DesignPatternsTemplates
{
    public class UserSingleton
    {
        public static UserSingleton Instance { get; private set; }
        public static User[] Users = UserFactory.GetUsers();

        private UserSingleton()
        {}



        public static UserSingleton getInstance()
        {
            if (Instance == null)
            {
                Instance = new UserSingleton();
            }
            return Instance;
        }

        public  User GetById(int id) { return Users[id];}

        public  User GetByName(string name)
        {
            User User = null;

            for(int i =0; i < Users.Length; i++)
            {
                if (Users[i].Name == name)
                    User =  Users[i];
            }

            return User;
        }

        public  User GetByEmail(string email)
        {
            User User = null;

            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Email == email)
                    User = Users[i];
            }

            return User;
        }

        public void PrintUsers()
        {
            Console.WriteLine("Users list");
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Id: {Users[i].Id}");
                Console.WriteLine($"Name: {Users[i].Name}");
                Console.WriteLine($"Email: {Users[i].Email}");
                Console.WriteLine("-------------------------");
                
            }

        }
    }
}