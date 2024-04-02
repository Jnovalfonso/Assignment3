using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            User user1 = new User(21,"Robinsuthar.rs07@gmail.com","RR","sa");
            User user2 = new User(213, "sdasd.rs07@gmail.com", "RR", "sa");
            User user3 = new User(21, "Asds", "Adsd", "Df");
            User user4 = new User(11, "Robin", "Adsd", "Df");
            User user5 = new User(41, "jatin", "Adsd", "Df");
            User user6 = new User(2, "Sandhu", "fg", "s");
            SLL Linkedlist = new SLL();

            Linkedlist.AddFirst(user6);
            Linkedlist.AddFirst(user5);
            Linkedlist.AddFirst(user4);
            //Linkedlist.AddLast(user5);
            //Linkedlist.AddLast(user6);

            //Linkedlist.RemoveLast();

            Linkedlist.GetValue(2);
            //Linkedlist.RemoveLast();
            Console.WriteLine(Linkedlist.Count());
            Linkedlist.DisplayList();
            Console.WriteLine(Linkedlist.Contains(user4));
            Console.WriteLine(Linkedlist.IndexOf(user4));
            Console.WriteLine(Linkedlist.IndexOf(user1));
            Console.WriteLine(Linkedlist.IsEmpty());

            Linkedlist.Clear();
            Console.WriteLine("CLEAR");
            Console.WriteLine(Linkedlist.Count());
            Console.WriteLine(Linkedlist.IsEmpty());
            Linkedlist.DisplayList();
            Console.WriteLine(Linkedlist.Contains(user4));

        }
    }
}
