using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp34
{
    public class Filter
    {
        public  List<User> users = new List<User>();



        

        internal void AddUser(User user)
        {
            users.Add(user);
        }

       
        

        public List<User> FindAge(int age)
        {
            return users.Where(x => x.Age > 20).ToList();
        }


        public List<User> GetAllUser()
        {
            return users;
        }

        public List<User> Remove()
        {
            var userList = users.Where(user => (user.Country == "Turkey") && (user.Age < 10)).ToList();

            foreach (var user in userList)
            {
                users.Remove(user);
            }

            return users;
        }
    }
}
