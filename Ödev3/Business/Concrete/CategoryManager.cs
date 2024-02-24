using Workspace.Business.Abstract;
using Workspace.Data_Access.Concrete;

namespace Workspace.Business.Concrete

{
    class CategoryManager : IObjectManager
    {
        public void Add() 
        {
            Console.WriteLine("Kategori eklendi.");
        }
        public void Update() 
        {
            Console.WriteLine("Kategori güncellendi.");
        }
        public void Delete() 
        { 
            Console.WriteLine("Kategori Silindi");
        }

    }



}