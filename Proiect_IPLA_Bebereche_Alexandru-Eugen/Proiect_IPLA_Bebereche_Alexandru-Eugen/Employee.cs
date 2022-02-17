using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Proiect_IPLA_Bebereche_Alexandru_Eugen
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Position { get; set; }
        public DateTime HideDate { get; set; }
        public int FreeDaysLeft { get; set; }

        public Employee(string name, float salary, string position, DateTime hideDate, int freeDaysLeft)
        {
            Name = name;
            Salary = salary;
            Position = position;
            HideDate = hideDate;
            FreeDaysLeft = freeDaysLeft;
        }

        //public Employee(string linie)
        //{
        //    string[] vector = linie.Split(',');

        //    Name = vector[0].Trim();
        //    //Salary = float.Parse(vector[1], CultureInfo.InvariantCulture);
        //    Salary = float.Parse(vector[1].Trim());
        //    Position = vector[2].Trim();
        //    HideDate = DateTime.Parse(vector[3], CultureInfo.InvariantCulture);
        //    FreeDaysLeft = int.Parse(vector[4], CultureInfo.InvariantCulture);
        //}

        public Employee()
        {

        }
    }
}
