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
        }
    }
}
