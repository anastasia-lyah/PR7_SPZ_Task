using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_SPZ_Task
{
    public class Abonent
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Tariff { get; set; }
        public double Balance { get; set; }
        public DateTime ActivationDate { get; set; }
        public bool HasInternet { get; set; }
        public bool HasDigitalTV { get; set; }
        public TimeSpan GetTimeExistence()
        {
            return DateTime.Now - ActivationDate;
        }
        public Abonent() { }

        public Abonent(string number, string name, string tariff, double balance, 
            DateTime activationDate, bool hasInternet, bool hasDigitalTV)
        {
            Number = number;
            Name = name;
            Tariff = tariff;
            Balance = balance;
            ActivationDate = activationDate;
            HasInternet = hasInternet;
            HasDigitalTV = hasDigitalTV;
        }
    }
}
