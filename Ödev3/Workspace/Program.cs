using System;
using System.Xml.Linq;
using Workspace.Business.Concrete;
using Workspace.Entities.Concrete;


namespace Workspace.Workspace

{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";   
            course.Price = 0;
            course.CourseID = 0;
            course.Description = "...";
            course.CompletionPercantage = 73;
            course.Category = "Programlama";
            course.Instructor = "Engin Demirog";

            Instructor instructor = new Instructor();
            instructor.InstructorId = 0;
            instructor.InstructorName = "Engin Demirog";
            instructor.InstructorBio = "...";

            Category category = new Category();
            category.CategoryId = 0;
            category.CategoryName = "Programlama";

            Console.WriteLine("Kurs adı: " + course.CourseName);
            Console.WriteLine("Kurs eğitmeni: " + course.Instructor);
            Console.WriteLine("Kurs fiyatı: " + course.Price);
            Console.WriteLine("Kurs Kategorisi: " + course.Category);

            CategoryManager categoryManager = new CategoryManager();
            categoryManager.Add();
            categoryManager.Update();
            categoryManager.Delete();

            InstructorManager instructorManager = new InstructorManager();
            instructorManager.Add();
            instructorManager.Update();
            instructorManager.Delete();

            CourseManager courseManager = new CourseManager();
            courseManager.Add();
            courseManager.Update();
            courseManager.Delete();




        }
    }



}