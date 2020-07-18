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
using System.Data.Linq.Mapping;

namespace Tarot_App.Model
{
    [Table(Name="GunlukTarih")]
    public class GunlukTarih
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column(CanBeNull=false)]
        public string gun { get; set; }
        [Column(CanBeNull = false)]
        public string ay { get; set; }
        [Column(CanBeNull = false)]
        public string yil { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",
                this.gun, this.ay, this.yil);
        }

    }
}
