using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace day1
{
   
    public class Program
    {

        static void Main(string[] args)
        {
            //uni code
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Employee[] employees =
            [
                new Employee(2,"Ahmed",new DateOnly(2024,5,11),3000.0m,Roles.DBA,Gender.Male),
                new Employee (3,"3bood",new DateOnly(2025,4,12),1000.0m,Roles.guest,Gender.Male),
                new Employee(4,"2llaa",new DateOnly(2023,12,6),7000.0m,Roles.SecurityOfficer,Gender.Female)
            ];

            //sorted employees based on the hirring date 
            Array.Sort(employees, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));

            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee_ID:{emp.Id} - Date_Of_Hirring{emp.HireDate}");
            }


            try
            {
                Console.WriteLine("enter the gender f/m");
                string? input = Console.ReadLine()?.Trim().ToUpper();


                if (string.IsNullOrEmpty(input))
                {
                    throw new GenderException();
                }

                else
                {
                    switch (input)
                    {
                        case "F":
                            input = Gender.Female.ToString();
                            break;
                        case "M":
                            input = Gender.Male.ToString();
                            break;
                        default:
                            throw new GenderException();

                    }


                    Enum.TryParse<Gender>(input, true, out Gender result);

                    foreach (var emp in employees)
                    {
                        if (emp.Genderr == result)
                            Console.WriteLine(emp);
                        ///بيشوف اول emp.Genderr != result ويشتغل عشان كده مش ظابط مع الفيميل
                        //else
                        //    throw new Exception();
                    }
                }
            }
            catch (GenderException)
            {
                Console.WriteLine("please enter the right format {F or M only}");
            }


            Roles SecurityOfficer = Roles.SecurityOfficer | Roles.DBA | Roles.Developer | Roles.secretary | Roles.guest;

            Console.WriteLine($"The Roles of SECUIRITY OFFICER Is: {SecurityOfficer}");
        }
    }
}
