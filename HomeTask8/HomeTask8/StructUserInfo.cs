using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    struct UserInfo
    {
        public string name;
        public string surname;
        public int age;
        public string adress;
        public string login;
        public string password;

        public UserInfo(string name, string surname, int age, string adress, string login, string password)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.adress = adress;
            this.login = login;
            this.password = password;
        }

        public UserInfo()
        {
            name = "Nikita";
            surname = "Shelby";
            age = 37;
            adress = "89-23 Lenina";
            login = "NikShelby1990";
            password = "Nik2023CSharp!";

        }

        public void Print()
        {
            Console.WriteLine($"User {name} {surname} is {age} years old, lives on {adress} str., has login: {login} & password {password}\n");
        }

    }
}
