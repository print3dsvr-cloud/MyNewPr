using System;


namespace MyNewPr.BL.Model
{
    [Serializable]
 public class DataPower
    {
        public double Current {  get; }
        public double Voltage { get; }
        public DateTime MyDateTime { get; } = DateTime.Now;

        public DataPower(double current, double voltage) 
        {
            Current = current;
            Voltage = voltage;
        }
        public override string ToString ()
        {
            return "Дата: " + MyDateTime + "; I = " + Current + "A ; U = " + Voltage + "V.\n";
        }

    }
}
