using ProjectNew1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNew1
{
    internal class StudentManagement
    {
        private List<Student> _students;

        public StudentManagement()
        {
            _students = new List<Student>();
            

            
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Delete(string registerNumber) 
        { 

        }

        public void Update(Student student)
        {

        }

        public Student Find(string registerNumber)
        {
            foreach (var item in _students)

            {
                if(item.RegisterNumber == registerNumber)
                {
                    Console.WriteLine("Found");
                    return item;
                }
                
            }
            return null;
        }

       
    }
}
