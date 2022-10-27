using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { Name = "Nihal", Age = 3, Address = "Uttara Model Town" };

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Address);

            Console.WriteLine(student.GetType());


            // var marks = new[] { new { tId = 1, TMarks = 80} };


            var marks = new[] {           
            new {tId =1, tName="Nihal Ahmed"},
            new {tId =2, tName="Fahim Ahmed"},
            new {tId =3, tName="Arif Ahmed"},
            new {tId =4, tName="Tuasar Ahmed"},
            new {tId =5, tName="Karim Ahmed"}        
            };

            foreach(var m in marks)
            {
                Console.WriteLine($"{m.tId} : {m.tName}");
            }



            Console.ReadKey();

        }//Main
    }//Class
}//Namespace
