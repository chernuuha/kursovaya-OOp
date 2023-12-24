using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace kurss
{
    public partial class HotelManager
    {
        public ObservableCollection<Hotel> Hotels { get; set; }
        public HotelManager()
        {

            Hotels = new ObservableCollection<Hotel>();

        }
        public void addHotel(Hotel hotel)
        {
            Hotels.Add(hotel);

        }
        public void deleteHotel(Hotel hotel)
        {
            Hotels.Remove(hotel);
        }
        public void SaveHotel(string filePath)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Hotel>));
                serializer.Serialize(streamWriter, Hotels);
            }
        }

        public void editHotel(Hotel oldHotel, Hotel newHotel) // Метод редактирования 
        {
            int index = Hotels.IndexOf(oldHotel);
            Hotels[index] = newHotel;
        }

        public void LoadHotel(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Hotel>));
                    ObservableCollection<Hotel> loadedHotels = (ObservableCollection<Hotel>)serializer.Deserialize(streamReader);

                    Hotels.Clear();
                    foreach (var hotel in loadedHotels)
                    {
                        Hotels.Add(hotel);
                    }
                }
            }
        }
    }
}
