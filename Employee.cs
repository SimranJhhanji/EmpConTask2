using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp2
{
    class Employee
    {
        private string name;
        private short age;
        private string emptype;
        
        

        public Employee(string name, short age, string emptype)
        {
            this.name = name;
            this.age = age;
            this.emptype = emptype;
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public short Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Emp_Type
        {
            get { return emptype; }
            set { emptype = value; }
        }
       
    }
}
