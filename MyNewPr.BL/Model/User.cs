using System;

namespace MyNewPr.BL.Model
{
    public class User
    {
        /// <summary>
        /// Пользователь
        /// </summary>
        public string UserName { get; }
        /// <summary>
        /// Порт подключения
        /// </summary>
        public string PortName { get; }
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="_UserName"> Имя пользователя</param>
        /// <param name="_PortName"> Номер порта для подключения</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public User(string _UserName, string _PortName) 
        {
            if(string.IsNullOrWhiteSpace(_UserName))
            {  throw new ArgumentNullException("Имя не может быть пустым или NULL", nameof(_UserName)); }
            if(string.IsNullOrWhiteSpace(_PortName))
            {  throw new ArgumentNullException("Порт не может быть пустым или NULL",nameof(PortName)); }
            UserName = _UserName;
            PortName = _PortName;
        }
        public override string ToString()
        {
            return "Имя пользователя: " + UserName + "/n Подключены к порту: " + PortName;
        }
    }
}
