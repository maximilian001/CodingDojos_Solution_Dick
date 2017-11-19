using CodingDojo3.SimulationDaten;
using GalaSoft.MvvmLight;
using Shared.BaseModels;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        private Simulator sim;
        private List<Daten> modelItems = new List<Daten>();

        public ObservableCollection<Daten> SensorList { get; set; }
        public ObservableCollection<Daten> ActorList { get; set; }
        public ObservableCollection<string> ModeSelectionList { get; private set; }



        private void DatenLaden()
        {
            Simulator sim = new Simulator(modelItems);
            foreach (var item in sim.Items)
            {
                if (item.ItemType.Equals(typeof(ISensor)))
                    SensorList.Add(item);
                else if (item.ItemType.Equals(typeof(IActuator)))
                    ActorList.Add(item);
            }
        }

        private void UpdaZeit_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Zeit = DateTime.Now.ToLocalTime().ToLongTimeString();
            Datum = DateTime.Now.ToLocalTime().ToShortDateString();

        }


        public MainViewModel()
        {
            updaZeit = new DispatcherTimer();
            updaZeit.Interval = TimeSpan.FromSeconds(1);
            updaZeit.Tick += UpdaZeit_Tick;
            updaZeit.Start();

            SensorList = new ObservableCollection<Daten>();
            ActorList = new ObservableCollection<Daten>();
            ModeSelectionList = new ObservableCollection<string>();

            foreach (var item in Enum.GetNames(typeof(SensorModeType)))
            {
                ModeSelectionList.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(ModeType)))
            {
                ModeSelectionList.Add(item);

            }


            if (!IsInDesignMode)
            {

                DatenLaden();


            }

           

        }

    }
}