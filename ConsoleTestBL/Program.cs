using System;

namespace ConsoleTestBL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BLApi.IBL bl = new BL.BLImp();

            try
            {
                BO.Student boStudent = bl.GetStudent(1);
            }
            catch (BO.MissingIdException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
