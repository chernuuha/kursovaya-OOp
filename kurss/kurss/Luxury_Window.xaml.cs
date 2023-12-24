using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kurss
{
    /// <summary>
    /// Логика взаимодействия для Luxury_Window.xaml
    /// </summary>
    /// 



    public partial class Luxury_Window : Window
    {
        private HotelManager hotelManager;
        public Luxury_Window(HotelManager manager)
        {
            InitializeComponent();

            hotelManager = manager;
        }



        private void OutBTN_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EmptyFields(String Name, string Geo, string Room, string Service, string Rating, LuxuryHotel LuxuryHotel)
        {
            if (Name != " " && Geo != " " && Room != " " && Service != "" && Rating != "")
            {
                hotelManager.addHotel(LuxuryHotel);
                MessageBox.Show("Luxury hotel added successfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Некорректно заполнены поля!", "Ошибка!", MessageBoxButton.OK);
            }
        }

            private void AddHotel_Click(object sender, RoutedEventArgs e)
        {
            LuxuryHotel luxuryHotel = new  LuxuryHotel()
            {

                Name = NameBox.Text,
                Geo = GeoBox.Text,
                Room = RoomBox.Text,
                Service = ServiceBox.Text,
                Rating = RatingBox.Text,
                type = HotelType.Роскошный



            };
            EmptyFields(luxuryHotel.Name,luxuryHotel.Geo, luxuryHotel.Room, luxuryHotel.Service, luxuryHotel.Rating, luxuryHotel);





        }

    }
}
