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
    /// Логика взаимодействия для EditHotel.xaml
    /// </summary>
    public partial class EditHotel : Window
    {
        private HotelManager hotelManager;
        private Hotel oldHotel;
        public EditHotel(HotelManager manager, Hotel hotel)
        {
            
            InitializeComponent();
            hotelManager = manager;
            oldHotel = hotel;

            NameBox.Text = oldHotel.Name;
            GeoBox.Text = oldHotel.Geo;
            RoomBox.Text = oldHotel.Room;
            ServiceBox.Text = oldHotel.Service;
            RatingBox.Text = oldHotel.Rating;
        }
        private void EmptyFields(String Name, string Geo, string Room, string Service, string Rating, Hotel newHotel)
        {
            if (Name != " " && Geo != " " && Room != " " && Service != "" && Rating != "")
            {
                hotelManager.editHotel(oldHotel, newHotel);
                MessageBox.Show("Successfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Некорректно заполнены поля!", "Ошибка!", MessageBoxButton.OK);
            }
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (oldHotel is BudgetHotel)
            {
                BudgetHotel budgetHotel = new BudgetHotel
                {
                    Name = NameBox.Text,
                    Geo = GeoBox.Text,
                    Room = RoomBox.Text,
                    Service = ServiceBox.Text,
                    Rating = RatingBox.Text,
                    type = HotelType.Бюджетный
                };
                EmptyFields(budgetHotel.Name, budgetHotel.Geo, budgetHotel.Room, budgetHotel.Service, budgetHotel.Rating, budgetHotel);
            }
            else if (oldHotel is LuxuryHotel)
            {
                LuxuryHotel luxuryHotel = new LuxuryHotel
                {
                    Name = NameBox.Text,
                    Geo = GeoBox.Text,
                    Room = RoomBox.Text,
                    Service = ServiceBox.Text,
                    Rating = RatingBox.Text,
                    type = HotelType.Роскошный
                 };
                EmptyFields(luxuryHotel.Name, luxuryHotel.Geo, luxuryHotel.Room, luxuryHotel.Service, luxuryHotel.Rating, luxuryHotel);
            }
            else
            {
                PresidentHotel presidentHotel = new PresidentHotel
                {
                    Name = NameBox.Text,
                    Geo = GeoBox.Text,
                    Room = RoomBox.Text,
                    Service = ServiceBox.Text,
                    Rating = RatingBox.Text,
                    type = HotelType.Президентский
                };
                EmptyFields(presidentHotel.Name, presidentHotel.Geo, presidentHotel.Room, presidentHotel.Service, presidentHotel.Rating, presidentHotel);
            }
        }

        private void OutBTN_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
