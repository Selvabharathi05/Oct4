using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALLibrary;

namespace class29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.Bookstable.Add(new Book { Bookno = 1, BookName = "The Great King", Author = "Loki" });
            context.Bookstable.Add(new Book { Bookno = 2, BookName = "The New Beginning", Author = "Thor" });
            context.SaveChanges();
            MyContext context2 = new MyContext();   
            context2.Memberstable.Add(new Member { MemberID =1, MemberName = "Selva", AccOpenDate = DateTime.Now});
            context2.Memberstable.Add(new Member { MemberID = 2, MemberName = "Bharathi", AccOpenDate = DateTime.Now });
            context2.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
            
        }
    }
}
