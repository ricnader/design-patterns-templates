﻿using DesignPatternsTemplates.Models;

namespace DesignPatternsTemplates.Factory
{
    public class UserFactory
    {
        public static User[] Users { get; private set; }

        public static User[] GetUsers() 
        {
            Users = new User[3];

            Users[0] = new User() { 
                Id= 1,
                Name = "John",
                Email = "John@Server.com"
            };

            Users[1] = new User()
            {
                Id = 2,
                Name = "Mary",
                Email = "Mary@Bol.com"
            };

            Users[2] = new User()
            {
                Id = 3,
                Name = "Mark",
                Email = "Mark@Gmail.com"
            };

            return Users;
        }
    }
}
