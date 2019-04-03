using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class TodoLibrary
    {
      public     MyList<string> mylist = new MyList<string>();
        
        private  void Welcome()
        {
            
            Console.ResetColor();
            Console.WriteLine(

                              "To See all activ notes enter - F1\n\n" +

                              "To Remove any notes enter    - F2\n\n" +

                              "To Complet list enter        - F3\n");
            
                             
            Console.WriteLine($"{mylist.Count}  Items\n");
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                
                case ConsoleKey.F1:
                   Show();
                    break;
                case ConsoleKey.F2:
                    Remove();
                    break;
                case ConsoleKey.F3:
                   Complet();
                    break;
                default:
                    Add();
                    break;

            }
            
        }

        public TodoLibrary()
        {
            Welcome();

        }

        void Add()
        {
            Console.Clear();
            Console.WriteLine("Enter your  note\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string s = Console.ReadLine();
         
            mylist.Add(s);
            Welcome();

        }

        void Show()
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            mylist.Show();
            Welcome();
        }
        void Remove()
        {
            Console.WriteLine("Enter note number you wont remove");
            int i = int.Parse(Console.ReadLine());
            mylist.Remove(mylist[--i]);
            Show();
        }
            void Complet()
            {
            Console.Clear();
            Welcome();
            }

    }
}
