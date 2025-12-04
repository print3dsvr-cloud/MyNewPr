using MyNewPr.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MyNewPr.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Создание нового контроллера порльзователя
        /// </summary>
        /// <param name="_User"> Полбьзователь приложения</param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController (string username)
        {  
             User = new User(username);
        }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Загрузить данные пользователя
        /// </summary>
        public User Load()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            { 
            if(formatter.Deserialize(fs) is User _User)
                {
                    return _User;
                }
                else
                {
                    throw new FileLoadException("Не удалось получить данные пользователя из файла", "users.dat");
                }
            }

        }

    }
}
