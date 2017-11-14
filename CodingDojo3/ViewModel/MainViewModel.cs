using GalaSoft.MvvmLight;
using System;
using System.Windows.Threading;


namespace CodingDojo3.ViewModel
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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 


        private string zeit;
        private string datum;

        public string Datum
        {
            get { return datum; }
            set { datum = value; RaisePropertyChanged(); }
        }


        public string Zeit
        {
            get { return zeit; }
            set { zeit = value; RaisePropertyChanged(); }
        }


        private DispatcherTimer updaZeit;




        public MainViewModel()
        {
            updaZeit = new DispatcherTimer();
            updaZeit.Interval = TimeSpan.FromSeconds(1);
            updaZeit.Tick += UpdaZeit_Tick;
            updaZeit.Start();
        }

        private void UpdaZeit_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Zeit = DateTime.Now.ToLocalTime().ToLongTimeString();
            Datum = DateTime.Now.ToLocalTime().ToShortDateString();
            
        }
    }
}