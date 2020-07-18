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
using System.Collections.Generic;

using Tarot_App.Model;


namespace Tarot_App
{
    public partial class MainPage : PhoneApplicationPage
    {

        private const string strConnectionString = @"isostore:/GunlukTarih.sdf";

        // Constructor
        public MainPage()
        {
            InitializeComponent();
          

       }

        string ay, gun, yil;
        public string zaman, zamanTemp;
       
        private void button1_Click(object sender, RoutedEventArgs e)
        {    
            

            if (zaman==zamanTemp)
             {
                 MessageBox.Show("Günlük bir tane kart seçebilirsiniz...");
                 NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

             }
             else
             {

                 NavigationService.Navigate(new Uri("/RandomCartPage.xaml", UriKind.Relative));
              }
            
        }

        static public string tarihKurtar;
        public List<GunlukTarih> gt = new List<GunlukTarih>();

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {


            

            using (GunlukTarihDataContext gunluk = new GunlukTarihDataContext(strConnectionString))
            {
                if (gunluk.DatabaseExists() == false)
                {
                    gunluk.CreateDatabase(); //veri tabanını oluşturdu...

                      GunlukTarih gnlktrh = new GunlukTarih
                    {
                        gun = Convert.ToString(DateTime.Now.Day),
                        ay = Convert.ToString(DateTime.Now.Month),
                        yil = Convert.ToString(DateTime.Now.Year)
                    };
                    
                //    gt.Add(gnlktrh);



                  //  MessageBox.Show(gnlktrh.gun + " " + gnlktrh.ay + " " + gnlktrh.yil);
                    zaman = this.gun + this.ay + this.yil;
                    MessageBox.Show("db için sistemin ilk tarihini aldım " + zaman);
                    tarihKurtar = zaman;

                    gunluk.GunlukTarihs.InsertOnSubmit(gnlktrh);
                    gunluk.SubmitChanges();



                    //var veriBilgileri = from vb in gt
                    //                    where vb.gun == Convert.ToString(DateTime.Now.Day) &&
                    //                          vb.ay == Convert.ToString(DateTime.Now.Month) &&
                    //                          vb.yil == Convert.ToString(DateTime.Now.Year)
                    //                    select vb;


                    //foreach(GunlukTarih es in veriBilgileri)
                    //{
                    //    MessageBox.Show("günde bir adet kars seçebilirsiniz");
                    //}




                    //MessageBox.Show(gnlktrh.gun + " " + gnlktrh.ay + " " + gnlktrh.yil);
                    //zaman = gnlktrh.gun + gnlktrh.ay + gnlktrh.yil;   //form ilk yüklendiğindeki sistemin tarihini alıyor.

                // MessageBox.Show("db için sistemin ilk tarihini aldım " + this.zaman);
                }
                 else
                {
                    gun = Convert.ToString(DateTime.Now.Day);
                    ay = Convert.ToString(DateTime.Now.Month);
                    yil = Convert.ToString(DateTime.Now.Year);

                    zamanTemp = gun + ay + yil; //sistemin o anki tarihini alıyor. 
                    MessageBox.Show("zamanTempin değeri " + zamanTemp);
             
                    //MessageBox.Show("Günlük bir tane kart seçebilirsiniz...");
                    //NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                  //  MessageBox.Show(gnlktrh.gun + " " + gnlktrh.ay + " " + gnlktrh.yil);
               //     zaman = gnlktrh.gun + gnlktrh.ay + gnlktrh.yil;   //form ilk yüklendiğindeki sistemin tarihini alıyor.
                   // MessageBox.Show("Veri tabanı oluşturulmuştur" + this.gun + " " + this.ay + " " + this.yil);
                  
             }

             //   MessageBox.Show("sistemin ilk tarihini aldım : " + tarihKurtar);
            }
             
            
           // zaman = Convert.ToString(DateTime.Now);
        }





    }
}