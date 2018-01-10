using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo6.ViewModel
{
    public class WarenkorbVM : ViewModelBase
    {
        public WarenkorbVM()
        {
            //Warenk = new ObservableCollection<ItemVM>();
            messenger.Register<PropertyChangedMessage<ItemVM>>(this, "Write", warehinzuf);
        }

        private ObservableCollection<ItemVM> warenk = new ObservableCollection<ItemVM>();

        public ObservableCollection<ItemVM> Warenk
        {
            get { return warenk; }
            set { warenk = value; RaisePropertyChanged(); }
        }

        private Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

        private void warehinzuf(PropertyChangedMessage<ItemVM> obj)
        {
            Warenk.Add(obj.NewValue);
        }

    }
}
