using Workspace.Business.Abstract;
using Workspace.Entities.Concrete;


namespace Workspace.Business.Concrete

{
    class CourseManager : IObjectManager
    {
        public void Add()
        {
            Console.WriteLine("Kurs eklendi.");
        }
        public void Update() 
        {
            Console.WriteLine("Kurs güncellendi.");
        }
        public void Delete() 
        {
            Console.WriteLine("Kurs silindi.");
        }



    }



}