using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kurss
{
   
    public enum HotelType
    {
        Бюджетный, Роскошный, Президентский
    }

    [Serializable]
    [XmlInclude(typeof(BudgetHotel))] // Включение всех типов контакта для сериализации и десериализации
    [XmlInclude(typeof(LuxuryHotel))]
    [XmlInclude(typeof(PresidentHotel))]
    public abstract class Hotel
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value; } }
        private string _Rating { get; set; }

        public string Rating { get { return _Rating; } set { _Rating = value; } }

        private string _Geo { get { return _Geo; } set { _Geo = value; } }

        public string Geo { get; set; }

        private string _Room { get; set; }

        public string Room { get { return _Room; } set { _Room = value; } }

        private string _Service { get; set; }

        public string Service { get { return _Service; } set { _Service = value; } }

        public HotelType type { get; set; }

        public override string ToString()
        {
            return $"Название:  {Name} \nОбщая оценка: {Rating} \nРасположение: {Geo} \nУбранство комнаты: {Room} \nОбслуживание: {Service} \nТип: {type}";
        }

        public virtual void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Name);
                writer.WriteLine(Geo);
                writer.WriteLine(Room);
                writer.WriteLine(Service);
                writer.WriteLine(Rating);
            }
        }
    }
}
