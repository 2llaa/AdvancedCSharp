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
    public struct Employee
    {
        public Employee(int id , DateOnly hireDate , decimal salary , Roles role , Gender gender )
        {
            Id = id;
            HireDate = hireDate;
            Salary = salary;
            Role = role;
            Genderr = gender;
        }
        public Employee() :this(1, new DateOnly(2025, 12, 10), 2000.0m,Roles.Developer,Gender.Female)
        {
        }

        public int Id { get; set; }
        public DateOnly HireDate { get; set; }
        private decimal Salary { get; set; }
        private Roles Role = Roles.Developer;
        public Gender Genderr = Gender.Female;



        public override string ToString()
        {
                                                                            //c is for currency
          return $"Id={Id} , Hire Date={HireDate} , Salary={Salary.ToString("C", CultureInfo.GetCultureInfo("en-EG"))}  , Role={Role}  , Gender={Genderr} ";
        }
         
        

        
    }
}
