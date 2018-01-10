using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CodingDojo6.ViewModel
{
    public class ProduktVM : ViewModelBase
    {
        private ItemVM auswahl;
        private Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();
        public ItemVM Auswahl
        {
            get { return auswahl; }
            set { auswahl = value; RaisePropertyChanged(); }
        }

        public ObservableCollection<ItemVM> Produkte { get; set; }
        public ObservableCollection<ItemVM> Warenkorb { get; set; }

        private RelayCommand<ItemVM> relayCommand;

        public RelayCommand<ItemVM> InDenWarenjorb
        {
            get { return relayCommand; }
            set { relayCommand = value; RaisePropertyChanged(); }
        }

        public ProduktVM()
        {
            Produkte = new ObservableCollection<ItemVM>();
            Warenkorb = new ObservableCollection<ItemVM>();
            InDenWarenjorb = new RelayCommand<ItemVM>(Klick);
            //InDenWarenjorb = new RelayCommand<ItemVM>;


            GenerateDemoData();
        }

        private void Klick(ItemVM obj)
        {
            messenger.Send<PropertyChangedMessage<ItemVM>>(new PropertyChangedMessage<ItemVM>(null, obj, "AddNew"), "Write");
            messenger.Send<PropertyChangedMessage<string>>(new PropertyChangedMessage<string>("", "Produkt wurde zum Warenkorb hinzugefügt", "Info"), "Info");
        }

        private void GenerateDemoData()
        {

            Produkte.Add(new ItemVM("MY Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "-"));
            Produkte.Add(new ItemVM("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "-"));
            Produkte[0].WareHinzufuegen(
                new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "5+"));
            Produkte[0].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "10+"));
            Produkte[1].WareHinzufuegen(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Produkte[1].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Produkte[1].WareHinzufuegen(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Produkte[1].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Produkte[1].WareHinzufuegen(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Produkte[1].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Produkte[1].WareHinzufuegen(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Produkte[1].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Produkte[0].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "10+"));
        }
    }
}
