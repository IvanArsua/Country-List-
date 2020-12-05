using System;
using RestSharp;
using Newtonsoft;
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
using Newtonsoft.Json;

namespace Country_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // not working yet problem with deserializeObject 
            var client = new RestClient("http://techslides.com/demos/country-capitals.json");
            var request = new RestRequest("", Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            var data  = JsonConvert.DeserializeObject<List<Countries>>(content);

            // only showing the numbers on the List 
            List<string> countries = new List<string> () { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
            List<string> names = new List<string>();

            int ctr = 0;
            foreach (string countryname in countries)
            {
                names.Add(ctr + " " + countries);
                ctr = ctr + 1;
            }
            lstCountries.ItemsSource = names;
            lstCountries.ItemsSource = data;
          
        }   

        
    }
}
