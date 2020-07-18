using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Tarot_App.Model
{
    public class Tarot
    {
        public int Id { get; set; }
        public string KartAdi { get; set; }
        public string Seri { get; set; }
        public string Images { get; set; }
        public string Aciklama { get; set; }

        public string RandomZaman { get; set; }
    }
}
