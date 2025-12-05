using MyNewPr.BL.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MyNewPr.BL.Controller
{
    public class DataPowerController
    {
        public List<DataPower> DataPowers { get;}
        
        public DataPowerController()
        {
         DataPowers = new List<DataPower>();
        }
        public void Add (double current, double voltage)
        {
            var DataPower = new DataPower(current, voltage);
            DataPowers.Add(DataPower);
        }
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("datapower.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, DataPowers);
            }
        }
        public DataPower Load()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("datapower.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is DataPower _DataPower)
                {
                    return _DataPower;
                }
                else
                {
                    throw new FileLoadException("Не удалось получить данные пользователя из файла", "datapower.dat");
                }
            }

        }
        public override string ToString()
        {
            string data = "List is DATA:\n";
            foreach (var DataPower in DataPowers)
            {
                data += DataPower.ToString();
            }
            return data;
        }
    }
}
