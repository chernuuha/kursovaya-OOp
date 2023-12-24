using kurss;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary
    public partial class MainPage : Window
    {
        private string _filePath;
        private HotelManager hotelManager;
       
        public MainPage()
        {

            InitializeComponent();
            hotelManager = new HotelManager();
            InfoBox.ItemsSource = hotelManager.Hotels;
            hotelManager.LoadHotel(_filePath);
        }



        private void OutBTN_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Luxury_Click(object sender, RoutedEventArgs e)
        {
            Luxury_Window luxury_Window = new Luxury_Window(hotelManager);
            luxury_Window.Show();
        }

        private void Budget_Click(object sender, RoutedEventArgs e)
        {
            Budget_Hotel budget_Hotel = new Budget_Hotel(hotelManager);
            budget_Hotel.Show();
        }

        private void President_Lux_Click(object sender, RoutedEventArgs e)
        {
            President_Hotel president_hotel = new President_Hotel(hotelManager);
            president_hotel.Show();
        }

        private void LoadHotels(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                openFileDialog.Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    _filePath = openFileDialog.FileName;
                    hotelManager.LoadHotel(_filePath);
                    MessageBox.Show("Файл успешно открыт!", "Открытие успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Выбран неверный формат файла! Выберите файл формата .xml", "Ошибка открытия файла", MessageBoxButton.OK);
            }
        }

        private void SaveHotels(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                saveFileDialog.Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    _filePath = saveFileDialog.FileName;
                    hotelManager.SaveHotel(_filePath);
                    MessageBox.Show("Файл успешно сохранен!", "Сохранение успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Выбран неверный формат файла! Выберите файл формата .xml", "Ошибка сохранения файла", MessageBoxButton.OK);
            }
        }

        private void EditHotel_Click(object sender, RoutedEventArgs e)
        {
            if (InfoBox.SelectedItem != null)
            {
                EditHotel editHotelWindow = new EditHotel(hotelManager, (Hotel)InfoBox.SelectedItem);
                editHotelWindow.Owner = this;
                editHotelWindow.ShowDialog();
            }
        }

        private void RemoveHotel_Click(object sender, RoutedEventArgs e)
        {
            if (InfoBox.SelectedItem != null)
            {
                Hotel hotel = (Hotel)InfoBox.SelectedItem;
                hotelManager.deleteHotel(hotel);
            }
        }
    }
}
