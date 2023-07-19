using System;
namespace demo_1.Services
{
    public class MenuService
    {
        private static StudentService studentService = new StudentService();

        public static void MenuShowStudents()
        {
            var students = studentService.GetStudents();

            if (students.Count == 0)
            {
                Console.WriteLine("No students yet.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
            }
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter grade:");
                double grade = double.Parse(Console.ReadLine());

                studentService.AddStudent(name, surname, grade);
                studentService.AddStudent(name, surname, grade);

                Console.WriteLine("Added student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuUpdateStudent()
        {
            try 
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter grade:");
                double grade = double.Parse(Console.ReadLine());
                studentService.AddStudent(name, surname, grade);
                studentService.AddStudent(name, surname, grade);

                Console.WriteLine("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                studentService.UpdateStudent(id);
                Console.WriteLine("Updated student successfuly!");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                studentService.RemoveStudent(id);

                Console.WriteLine("Deleted student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuFindStudentByName()
        {
            // search by name

            // if multiple show multiple
        }
    }
}
