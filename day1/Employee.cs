using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal struct Employee
    {
        internal Employee(int id ,string name, DateOnly hireDate , decimal salary , Roles role , Gender gender )
        {
            Id = id;
            Name = name;
            HireDate = hireDate;
            Salary = salary;
            Role = role;
            Genderr = gender;
        }
        public Employee() : this(1, "2llaa", new DateOnly(2025, 12, 10), 2000.0m,Roles.Developer,Gender.Female)
        {
        }

        internal int Id { get; set; }
        internal string Name { get; set; }
        internal DateOnly HireDate { get; set; }
        private decimal Salary { get; set; }
        private Roles Role = Roles.Developer;
        internal Gender Genderr = Gender.Female;



        public override string ToString()
        {
                                                                            //c is for currency
          return $"Id={Id} , Name={Name} Hire Date={HireDate} , Salary={Salary.ToString("C", CultureInfo.GetCultureInfo("en-EG"))}  , Role={Role}  , Gender={Genderr} ";
        }
         
        

        
    }
}
