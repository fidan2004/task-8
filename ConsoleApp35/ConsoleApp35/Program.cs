using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    public class Program
    {
        public static Filter users = new Filter();
        public static void Main(string[] args)
        {
            DateBase();
            var all = users.GetAllUser();
            var result1 = ListToString(all);
            Console.WriteLine(result1);


            var age = users.FindAge(20);
            var result2 = FindbyAge(age);
            Console.WriteLine(result2);

            var r = users.Remove();
            var result3 = Removee(r);
            Console.WriteLine(result3);



            static string ListToString(List<User> list1)
            {
                string str = " ";

                foreach (var item in list1)
                {
                    str += item.Name + " " + item.Surname + ".";
                }


                return str;

            }

            static string FindbyAge(List<User> list1)
            {
                string str1 = " ";
                foreach (var item in list1)
                {
                    str1 += item.Name + " " + item.Surname + " " + item.Age + " " + item.Country + ".";
                }
                return str1;
            }

             static string Removee(List<User> list1)
            {
                string str2 = " ";

                foreach (var item in list1)
                {
                    str2 += item.Name + " " + item.Surname + " " + item.Age + " " + item.Country + ".";
                }
                return str2;
            }






            static void Adduserr(User users)
            {

                List<User> us = new List<User>();
                us.Add(users);
                foreach (User user in us)
                {
                    Console.WriteLine(user);
                }

            }

            static void FindByAge(int age)
            {
                List<User> us = users.FindAge(age);
                us.ForEach(x => x.ToString());
            }




            static void DateBase()
            {

                var user1 = new User("fidan", "karimova", 18, "Azerbaijan");
                var user2 = new User("jala", "karimova", 21, "England");
                var user3 = new User("aygun", "karimova", 23, "Germany");
                var user4 = new User("anar", "karimova", 35, " Australia");
                var user5 = new User("ayla ", "karimova", 40, "Turkey");
                var user6 = new User("nigar", "karimova", 60, " Russia");
                var user7 = new User("lala", "karimova", 13, "Ukrania");
                var user8 = new User("rehim", "karimova", 15, "Ukrania");
                var user9 = new User("fidan", "karimova", 18, "Ukrania");
                var user10 = new User("gunel", "karimova", 20, "Ukrania");
                users.AddUser(user1);
                users.AddUser(user2);
                users.AddUser(user3);
                users.AddUser(user4);
                users.AddUser(user5);
                users.AddUser(user6);
                users.AddUser(user7);
                users.AddUser(user8);
                users.AddUser(user9);
                users.AddUser(user10);





            }
        }
    }
}
