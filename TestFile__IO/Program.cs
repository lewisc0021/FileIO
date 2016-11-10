using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile__IO
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<Employee> EmployeeList = ReadDataFromFile();

            ///////////////////////////////////////////////////
            foreach (Employee Emp in EmployeeList)
            {
                Console.WriteLine($"Name : {Emp.Name1}, Salary : {Emp.Salary1}");
            }

            WriteDataToFile("Q","100000");

        }//MAIN

        private static void WriteDataToFile(string name, string salary)
        {
            StreamWriter sw = new StreamWriter("../../DataFile.txt", true);
            sw.Write($"\n{name},{salary}");
            sw.Close();
        }

        private static List<Employee> ReadDataFromFile()
        {
            List<Employee> EmployeeList = new List<Employee>();

            string fileLocation = "../../DataFile.txt";

            StreamReader reader = new StreamReader(fileLocation);

            string Data = reader.ReadToEnd().Trim();

            string[] Records = Data.Split('\n');

            foreach (string record in Records)
            {
                string[] rc = record.Split(',');
                EmployeeList.Add(new Employee(rc[0].Trim(), float.Parse(rc[1].Trim())));
            }
            reader.Close(); //must close resources before you try to use it again in another capacity
            return EmployeeList;
        }
    }
}
