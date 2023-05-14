using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop__Business_Application__with__BL__DL___UI_.menu_UI;
using week_5_oop__Business_Application__with__BL__DL___UI_.Muser_BL;
using week_5_oop__Business_Application__with__BL__DL___UI_.Muser_CRUD;
using week_5_oop__Business_Application__with__BL__DL___UI_.Muser_UI;

namespace week_5_oop__Business_Application__with__BL__DL___UI_
{
    public class Program
    {
        static List<Muser> flights = new List<Muser>();
        static void Main(string[] args)
        {
            int option;
            do
            {             
                Console.Clear();
                option = menuUI.optmenu();
                Console.Clear();
                if (option == 1)
                {
                    Muser user = muserUI.takeinput();
                    MuserCRUD.addtolist(user, flights);

                }
                else if (option == 2)
                {
                    MuserCRUD.viewflights(flights);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    MuserCRUD.updateflights(flights);

                }
                else if (option == 4)
                {
                    MuserCRUD.deleterecord(flights);
                }
                else if (option == 5)
                {
                    break;
                }

            }
            while (option < 6);
            Console.Read();

            Console.ReadKey();
        }
    }
 }
