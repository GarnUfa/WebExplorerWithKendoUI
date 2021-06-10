using System;
using System.Linq;
using Testing.Model;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            using(TestContext context = new TestContext())
            {
                // Folder folder1 = new Folder() {FolderName = "folder1"};
                // Folder folder2 = new Folder() { FolderName = "folder2", ParentFolder = folder1};
                // context.Folders.AddRange(folder1, folder2);
               var qwe = context.Folders.ToList();
               context.Folders.Remove(context.Folders.ToList().Where(e => e.ID == 4).ToList()[0]);
               context.SaveChanges();
            }
        }
    }
}
