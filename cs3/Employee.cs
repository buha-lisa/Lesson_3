using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs3
{
    internal class Employee
    {
        public string PIP { get; set; }
        public Data BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public string Responsib { get; set; }

        public Employee(string pip, Data data, string phone, string email, string post, string respon)
        {
            PIP = pip;
            BirthDay = data;
            Phone = phone;
            Email = email;
            Post = post;
            Responsib = respon;
        }
        public void ShowInfo(Data data)
        {
            Console.WriteLine($"PIP:\t{PIP}");
            data.ShowData();
            Console.WriteLine($"Phone:\t{Phone}");
            Console.WriteLine($"Email:\t{Email}");
            Console.WriteLine($"Post:\t{Post}");
            Console.WriteLine($"Responsibilities:\n{Responsib}");
        }
    }
}
