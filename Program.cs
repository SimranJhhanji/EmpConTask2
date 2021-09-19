using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            //creating new Employee object 
            elist.Add(new Employee("Mahesh Chand", 35,"Temp"));
            

            foreach (var author in elist)
            {
                Console.WriteLine("Name = {0}, Age = {1}, Type of Employee = {2}", author.Name ,author.Age, author.Emp_Type);
            }

            try
            {

                StreamWriter sw = new StreamWriter(@"F:\data2.txt");

                sw.Write(elist);


                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("***The file is generated at data2.txt***");
            }


            Console.ReadKey();
        }
    }
    }

