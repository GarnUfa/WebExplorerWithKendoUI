using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TestingEF_SQL.Model;

namespace TestingEF_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WebExplorerContext db = new WebExplorerContext())
            {
                Folder rootFolder = db.Folders.Where(f => f.ID == 1).First();
                Folder Folder0 = new Folder() { Name = "Folder0", ParentFolder = rootFolder };
                Folder Folder1 = new Folder() { Name = "Folder1", ParentFolder = Folder0 };
                File File1 = new File() { Name = "File1", Description = "sdsd", ParentFolder = rootFolder };
                File File2 = new File() { Name = "File2", ParentFolder = Folder1, Description = "sdsd" };
                File File3 = new File() { Name = "File3", ParentFolder = Folder1, Description = "2222" };
                db.AddRange(Folder1, File2, File1, File3);
                db.SaveChanges();
                //var node = db.Nodes.ToList();
                //foreach (var n in node)
                //    Console.WriteLine(n.Name +" "+ n.GetType());
                //db.Folders.Remove(db.Folders.Where(f => f.Name == "Folder0").First());
                //db.SaveChanges();

            }
            Console.WriteLine("fin");
        }
    }
}
