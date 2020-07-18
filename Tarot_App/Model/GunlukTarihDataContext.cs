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
using System.Data.Linq;

namespace Tarot_App.Model
{
    public class GunlukTarihDataContext : DataContext
    {
        public GunlukTarihDataContext(string connectionString)
            : base(connectionString)
        { }

        public Table<GunlukTarih> GunlukTarihs
        {
            get
            {
                return this.GetTable<GunlukTarih>();
            }

        }

    }
}
