using Workspace.Business.Abstract;

namespace Workspace.Business.Concrete

{
    class InstructorManager : IObjectManager
    {
        public void Add() 
        {
            Console.WriteLine("Eğitmen eklendi.");
        }
        public void Update() 
        {
            Console.WriteLine("Eğitmen güncellendi.");
        }
        public void Delete() 
        {
            Console.WriteLine("Eğitmen silindi.");
        }
    }



}