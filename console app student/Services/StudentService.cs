using System;
using System.Collections.Generic;
using demo_1.Models;
using System.Linq;

namespace demo_1.Services
{
    public class StudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(string name, string surname, double grade)
        {

            var student = new Student(name, surname, grade);

            students.Add(student);
        }
        public void UpdateStudent(string name, string surname, double grade , int id)
        {
            var student = new Student (name, surname, grade, id);
            
            var existingStudent = students.FirstOrDefault(x => x.Id ==  id);
            
        }
        public void RemoveStudent(int id)
        {
            if (id <  0 ) throw new Exception("Invalid IO: ID cannot be negative!");

            var existingStudent = students.FirstOrDefault(x => x.Id == id);

            if (existingStudent == null) throw new Exception("Not found!");

            students = students.Where(x => x.Id != id).ToList();
        }

        internal void UpdateStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
