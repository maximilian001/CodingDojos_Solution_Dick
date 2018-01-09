using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo5.ViewModel
{
    public class ItemVM
    {
        public ItemVM(string beschreibung, BitmapImage bitmap, string alter)
        {
            Beschreibung = beschreibung;
            Bitmap = bitmap;
            Alter = alter;
        }

        public string Beschreibung { get; set; }
        public BitmapImage Bitmap { get; set; }
        public ObservableCollection<ItemVM> Artikel { get; set; }
        public string Alter { get; set; }

        public void WareHinzufuegen(ItemVM artikel)
        {
            if(Artikel == null)
            {
                Artikel = new ObservableCollection<ItemVM>();
            }
            Artikel.Add(artikel);
        }

    }
}
