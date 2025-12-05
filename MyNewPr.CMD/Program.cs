using MyNewPr.BL.Controller;
using System;

namespace MyNewPr.CMD
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя:");

            var name = Console.ReadLine();
            var userController = new UserController(name);
            userController.Save();
            var ran= new Random();
            DataPowerController dataPowerController = new DataPowerController();

            for (int i = 0; i<100; i++)
            {
                dataPowerController.Add(ran.NextDouble()*22.2, ran.NextDouble()*99.4);
               
            }
            Console.WriteLine(dataPowerController.ToString());
            dataPowerController.Save();
            dataPowerController.Load();
            Console.WriteLine(dataPowerController.ToString());
        }
    }
}
