using Exercises.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context=new StudentSystemContext())
            {
                // ListAll(context);
                ListAllCourses5(context);
            }
            Console.ReadKey();

        }
        private static void ListAll(StudentSystemContext context)
        {
            //Task 1

            var students = context.Students.ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);

                var homework = context.Homeworks
                    .Where(h => h.Student.Name == student.Name)
                    .Select(h => h);

                foreach (var homeworkSubmission in homework)
                {
                    Console.WriteLine($"{homeworkSubmission.Content} - {homeworkSubmission.ContentType}");
                }
            }
        }
        private static void ListAllCourses(StudentSystemContext context)
        {
            //Task 3.2
            var courses = context.Cources
                .OrderBy(c => c.StartDate)
                .ThenByDescending(c => c.EndDate)
                .ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Name} {course.Description}");

                var resources = context.Resources
                    .Where(r => r.Course.Name == course.Name)
                    .Select(r => r).ToList();

                foreach (var resource in resources)
                {
                    Console.WriteLine($"{resource.Id} {resource.Name} {resource.ResourceType} {resource.Url}");
                }
            }
        }

        private static void ListAllCourses5(StudentSystemContext context)
        {
            //Task 3.3
            var courses = context.Cources.Where(c => c.Resources.Count() > 2)
                            .OrderByDescending(c => c.Resources.Count)
                            .ThenByDescending(c => c.StartDate)
                            .ToList();

            foreach (var cource in courses)
            {
                Console.WriteLine($"{cource.Name}: {cource.Price} resources");
            }
        }
    }
}
