using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudy
{
    class Pacient
    {
        private string Surname;
        private string Sex;
        private int Age;

        public string GetSurname()
        {
            return Surname;
        }
        public void SetSurname(string Surname)
        {
            if (Surname.Length >= 20)
                Console.WriteLine("Surname must be less than 20 characters");
            else
                this.Surname = Surname;
        }

        public string GetSex()
        {
            return Sex;
        }
        public void SetSex(string Sex)
        {
            this.Sex = Sex;
        }

        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int Age)
        {
            this.Age = Age;
        }

    }
}
