using DbProductsORm.Data.Models;
using DbProductsORm.Presentation;
using System;

namespace DbProductsORm
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductContext db = new ProductContext();
            db.Database.EnsureCreated();
            Display display = new Display();
        }
    }
}
