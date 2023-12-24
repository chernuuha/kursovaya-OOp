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
    /// Логика взаимодействия для Budget_Hotel.xaml
    /// </summary>
    public partial class Budget_Hotel : Window
    {
        private HotelManager hotelManager;
        public Budget_Hotel(HotelManager manager)
        {
            
            InitializeComponent();

            hotelManager = manager;
        }
        private void OutBTN_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EmptyFields(String Name, string Geo, string Room, string Service, string Rating, BudgetHotel budgetHotel)
        {
            if (Name != " " && Geo != " " && Room != " " && Service != "" && Rating != "")
            {
                hotelManager.addHotel(budgetHotel);
                MessageBox.Show("Budget hotel added successfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Некорректно заполнены поля!", "Ошибка!", MessageBoxButton.OK);
            }

        }

        private void AddHotel_Click(object sender, RoutedEventArgs e)
        {

            BudgetHotel budgetHotel = new BudgetHotel()
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

      
        
    }
}
    

