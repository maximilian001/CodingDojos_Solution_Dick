using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Threading;
using System.Windows.Media.Imaging;

namespace CodingDojo6.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        private ViewModelBase aktuell;      

        public ViewModelBase Aktuell
        {
            get { return aktuell; }
            set { aktuell = value; RaisePropertyChanged(); }
        }

        private Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

        DispatcherTimer timer = new DispatcherTimer();

        private BitmapImage image;

        public BitmapImage InfoIcon
        {
            get { return image; }
            set { image = value; RaisePropertyChanged(); }
        }


        private string produktHinzugef = "";

        public string ProduktHinzugef
        {
            get { return produktHinzugef; }
            set { produktHinzugef = value; RaisePropertyChanged(); }
        }


        public RelayCommand ProdukteKlick { get; set; }
        public RelayCommand WarenkorbKlick { get; set; }

        public MainViewModel()
        {
            //Aktuell = SimpleIoc.Default.GetInstance<WarenkorbVM>();
            Aktuell = SimpleIoc.Default.GetInstance<ProduktVM>();
            ProdukteKlick = new RelayCommand(ProdKlCommand);
            WarenkorbKlick = new RelayCommand(WarKlCommand);

            messenger.Register<PropertyChangedMessage<string>>(this, "Info", showInfo);


        }

        private void showInfo(PropertyChangedMessage<string> obj)
        {
            ProduktHinzugef = obj.NewValue;
            InfoIcon = new BitmapImage(new Uri("ok.png", UriKind.Relative));
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
            ProduktHinzugef = obj.NewValue;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProduktHinzugef = "";
            InfoIcon = null;
            timer.Stop();
        }

        private void WarKlCommand()
        {
            Aktuell = SimpleIoc.Default.GetInstance<WarenkorbVM>();
        }

        private void ProdKlCommand()
        {
            Aktuell = SimpleIoc.Default.GetInstance<ProduktVM>();
        }
    }
}