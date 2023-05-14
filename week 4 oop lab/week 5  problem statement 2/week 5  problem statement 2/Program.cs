using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5__problem_statement_2
{
    class Program
    {
        
       public class book
        {
             public book()
            {

            }
            public book(string author, int pages, int price , int bookmark , List<string> chapters)
            {
                this.author = author;
                this.pages = pages;
                this.price = price;
                this.bookmark = bookmark;
                this.chapters = chapters;

            }

            public book addinfo()
            {
                List<string> chapters = new List<string>();
                Console.WriteLine("Enter the author name : ");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the number of pages in the book : ");
                int page = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the price of book : ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter on which page is the bookmark : ");
                int bookmark = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter how many chapters you want to add in this book");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of chapters : ");
                for (int idx = 0; idx < count; idx ++)
                {
                    string c = Console.ReadLine();
                    chapters.Add(c);
                }
                book b = new book(author, page, price, bookmark, chapters);
                return b;
            }

            public string nameofchapter(int chapternumber)
            {
                for(int idx = 0; idx < chapters.Count ; idx ++)
                {
                    if (chapternumber == idx)
                    {
                        return chapters[idx];
                    }
                }
                return null;
            }
            public int getbm()
            {
                
                return bookmark;

            }

            public void updatebm(int pagenumber)
            {
                bookmark = pagenumber;
              
            }
            public int getbp()
            {
                return price;
            }
            public void updatebookprice(int bookprice)
            {
                price = bookprice;
            }
           
            public string author;
            public int pages;
            public int price;
            public int bookmark;
            public List<string> chapters;
        }
        
        static void Main(string[] args)
        {
            int option;
            book b = new book();
            List<book> books = new List<book>();
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if(option == 1)
                {
                    b = b.addinfo();
                    books.Add(b);
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter the chapter number whom name you want : ");
                    int chapternumber = int.Parse(Console.ReadLine());
                    chapternumber = chapternumber - 1;
                    string cn = b.nameofchapter(chapternumber);
                    chapternumber++;
                    Console.WriteLine("The name of the chapter at the index " + chapternumber + " is " + cn);
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    int bm = b.getbm();
                    Console.WriteLine("BookMark is on page number : " + bm);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    Console.WriteLine("Enter on which page number you want to set the book mark:");
                   int pagenumber = int.Parse(Console.ReadLine());
                   b.updatebm(pagenumber);
                   Console.WriteLine("Your update bookmark is now on page number " + b.bookmark);
                    Console.ReadKey();
                }
                if(option == 5)
                {
                    int bp = b.getbp();
                    Console.WriteLine("Book Price is : " + bp);
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    Console.WriteLine("Enter the new book price of the book");
                    int bookprice = int.Parse(Console.ReadLine());
                    b.updatebookprice(bookprice);
                    Console.WriteLine("Your update bookprice is now " + b.price);
                    Console.ReadKey();
                }
                if (option == 7)
                {
                    break;
                }
            }
            while (option < 7);
            Console.Read();


        }

        static int menu()
        {
            int option;
            Console.WriteLine("1.Add the info of the book");
            Console.WriteLine("2.Get the name of chapter");
            Console.WriteLine("3.Get on which page is the bookmark");
            Console.WriteLine("4.Set/Update the new bookmark");
            Console.WriteLine("5.Get the price of the book");
            Console.WriteLine("6.Set/Update the new price of book");
            Console.WriteLine("7.Exit");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
