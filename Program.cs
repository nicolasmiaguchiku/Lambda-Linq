using System;
using Linq.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace Linq
{
    class Program
    {
        static void Printer<T>(string Message, IEnumerable<T> obj)
        {
            Console.WriteLine(Message);
            foreach (T p in obj)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            List<Empoyees> list = new List<Empoyees>
      {
        new Empoyees {Name = "Nicolas", Salary = 3000.00, Seniority = "Junior", SoftwareEngineering = "BackEnd" },
        new Empoyees {Name = "João", Salary = 3500.00, Seniority = "Junior", SoftwareEngineering = "Mobile"},
        new Empoyees {Name = "Thiago", Salary = 1000.00, Seniority = "Estagiario", SoftwareEngineering = "FrontEnd"},
        new Empoyees {Name = "Matheus", Salary = 5000.00, Seniority = "Pleno", SoftwareEngineering = "FullStack"},
        new Empoyees {Name = "Felipe",Salary = 10000.00, Seniority = "Senior", SoftwareEngineering = "DataAnalyst"},
        new Empoyees {Name = "Leonardo", Salary = 3000.00, Seniority = "junior", SoftwareEngineering = "BackEnd" },
        new Empoyees {Name = "Pedro", Salary = 5000.00, Seniority = "Senior", SoftwareEngineering = "FrontEnd"},
        new Empoyees {Name = "Douglas", Salary = 4000.00, Seniority = "Pleno", SoftwareEngineering = "Mobile"},
        new Empoyees {Name = "Lucas",Salary = 1800.00, Seniority = "Pleno", SoftwareEngineering = "FullStack"},
        new Empoyees {Name = "Marcelo", Salary = 13500.00, Seniority = "Senior", SoftwareEngineering = "BackEnd"},
      };

            var FrontEnd = list.Where(e => e.SoftwareEngineering == "FrontEnd");
            Printer("Desenvovedores FrontEnd: ", FrontEnd);

            Console.WriteLine();
            Console.WriteLine();

            var BackEnd = list.Where(e => e.SoftwareEngineering == "BackEnd");
            Printer("Desenvolvedores BackEnd:", BackEnd);

            var FullStack = list.Where(e => e.SoftwareEngineering == "FullStack");
            Printer("Desenvolvedores FullStack:", FullStack);

            var Mobile = list.Where(e => e.SoftwareEngineering == "Mobile");
            Printer("Desenvolvedores FullStack:", Mobile);

            var DataAnalyst = list.Where(e => e.SoftwareEngineering == "DataAnalyst");
            Printer("Desenvolvedores FullStack:", DataAnalyst);

            var MediaSalarioJunior = list.Where(e => e.Seniority == "Junior").Select(e => e.Salary).Average();
            Console.WriteLine("Media Salario Dos junior: " + MediaSalarioJunior.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
