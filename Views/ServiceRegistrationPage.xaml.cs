using Microsoft.EntityFrameworkCore.Storage;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VelvetEyrbrown.Models;


namespace VelvetEyrbrown.Views
{
    /// <summary>
    /// Логика взаимодействия для ServiceRegistrationPage.xaml
    /// </summary>
    public partial class ServiceRegistrationPage : Page
    {
        public Service Service { get; set; }
        public List<Service> Services { get; set; }
        public Client Client { get; set; }
        public List<Client> Clients { get; set; }

        public ServiceRegistrationPage(Service service)
        {
            InitializeComponent();
            Service = service;
            Services = Session.Instance.Context.Services.OrderBy(s => s.Title).ToList();
            Clients = Session.Instance.Context.Clients.OrderBy(c => c.LastName).ToList();
            serviceDatePicker.DisplayDateStart = DateTime.Today;
            serviceDatePicker.SelectedDate = DateTime.Today;
            serviceTimePicker.SelectedTime = new DateTime().AddHours(DateTime.Now.Hour + 1);
            DataContext = this;
        }
        private void registration(object sender, RoutedEventArgs e)
        {
            var time = serviceTimePicker.SelectedTime.Value;
            var date = serviceDatePicker.SelectedDate.Value;
            var startTime = date.AddTicks(time.Ticks);
            var clientService = new ClientService
            {
                Client = this.Client,
                Service = this.Service,
                StartTime = startTime,
                Comment = commentTextBox.Text,
            };
            Session.Instance.Context.ClientServices.Add(clientService);
            try
            {
                Session.Instance.Context.SaveChanges();
                MessageBox.Show("Клиент записан!");
                NavigationService.GoBack();
            }
            catch
            {
                MessageBox.Show("Ошибка при записи клиента!");
                Session.Instance.Context.ClientServices.Remove(clientService);
            }
        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
