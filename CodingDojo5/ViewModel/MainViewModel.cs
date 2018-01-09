using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo5.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ItemVM auswahl;

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


        public MainViewModel()
        {

            Produkte = new ObservableCollection<ItemVM>();
            Warenkorb = new ObservableCollection<ItemVM>();
            InDenWarenjorb = new RelayCommand<ItemVM>(Klick);
            //InDenWarenjorb = new RelayCommand<ItemVM>;


            GenerateDemoData();
        }

        private void Klick(ItemVM obj)
        {
            Warenkorb.Add(obj);
        }

        private void GenerateDemoData()
        {

            Produkte.Add(new ItemVM("MY Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "-"));
            Produkte.Add(new ItemVM("MY Playmobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "-"));
            Produkte[0].WareHinzufuegen(
                new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Produkte[0].WareHinzufuegen(
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
            Produkte[1].WareHinzufuegen(
               new ItemVM("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            Produkte[1].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            Produkte[0].WareHinzufuegen(
                new ItemVM("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
        }
    }
}