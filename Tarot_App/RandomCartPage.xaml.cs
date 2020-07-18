using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;


using Microsoft.Phone.Data.Linq;
using Tarot_App.Model;
using System.Xml.Linq;

namespace Tarot_App
{
    public partial class RandomCartPage : PhoneApplicationPage
    {
        public RandomCartPage()
        {
            InitializeComponent();
        }

        
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            Tarot tarihAl = new Tarot();
            tarihAl.RandomZaman = Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Year);
           
            Random numbers = new Random();
            int index = numbers.Next(1, 78);

            XDocument loadedCustomData = XDocument.Load("TarotData.xml");
            var filteredData = from query in loadedCustomData.Descendants("Tarot")
                               where query.Attribute("Id").Value == index.ToString()
                               select new Tarot()
                               {
                                   KartAdi = query.Attribute("KartAdi").Value,
                                   Seri = query.Attribute("Seri").Value,
                                   Aciklama = query.Attribute("Aciklama").Value,
                                   Images = query.Attribute("Images").Value

                               };
            listBox1.ItemsSource = filteredData;
        }
    }
}