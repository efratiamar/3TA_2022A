﻿using System;


namespace ConsoleTestDL
{
    class Program
    {

        enum MenuOptions { Exit, Add, Update, ShowOne, ShowList }
        enum AddOptions { Exit, Adddrone, AddStation}
        void PrintMenu()
        {

            MenuOptions mo;

            //read ;
            int opt;
            bool b = int.TryParse(Console.ReadLine(),out opt);
            mo = (MenuOptions)opt;
            switch (mo)
            {
                case MenuOptions.Exit:

                    break;
                case MenuOptions.Add:

                    break;
                case MenuOptions.Update:

                    break;
                case MenuOptions.ShowOne:
                    break;
                case MenuOptions.ShowList:
                    break;
                default:
                    break;
            }

        }
        
        static void Main(string[] args)
        {
            
           DalObject.DalObject dl = new DalObject.DalObject();

            try
            {
                DO.Student boStudent =  dl.GetStudent(1);
            }
            catch(DO.MissingIdException ex)
            {
                Console.WriteLine(ex);
            }
                                 
        }
    }
}
