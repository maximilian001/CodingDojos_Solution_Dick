using GalaSoft.MvvmLight;
using Shared.BaseModels;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModel
{
    public class Daten : ViewModelBase
    {
        private ItemBase elem;

        public int Id
        {
            get { return elem.Id; }
        }

        public string Description
        {
            get { return elem.Description; }
            set { elem.Description = value; RaisePropertyChanged(); }
        }

        public string Name
        {
            get { return elem.Name; }
            set { elem.Name = value; RaisePropertyChanged(); }
        }

        public string Room
        {
            get { return elem.Room; }
            set { elem.Room = value; RaisePropertyChanged(); }
        }

        public int PosX
        {
            get { return elem.PosX; }
            set { elem.PosX = value; RaisePropertyChanged(); }
        }

        public int PosY
        {
            get { return elem.PosY; }
            set { elem.PosY = value; RaisePropertyChanged(); }
        }

        public string ValueType
        {
            get
            {
                if (elem is ISensor)
                    return (elem as BaseSensor).SensorValueType.Name;
                else if (elem is IActuator)
                    return (elem as BaseActuator).ActuatorValueType.Name;
                else
                    throw new NotImplementedException();
            }

        }
        public Type ItemType
        {
            get
            {
                if (elem is ISensor) return typeof(ISensor);
                else if (elem is IActuator) return typeof(IActuator);
                else throw new NotImplementedException();
            }
        }

        public string Mode
        {
            get
            {
                if (elem is ISensor) return (elem as BaseSensor).SensorMode.ToString();
                if (elem is IActuator) return (elem as BaseActuator).ActuatorMode.ToString();
                else return null;
            }
            set
            {
                if (elem is ISensor)
                    (elem as BaseSensor).SensorMode = (SensorModeType)Enum.Parse(typeof(SensorModeType), value, false);
                if (elem is IActuator)
                    (elem as BaseActuator).ActuatorMode = (ModeType)Enum.Parse(typeof(ModeType), value, false);

                RaisePropertyChanged();
            }
        }

        public object Value
        {
            get
            {
                if (elem is ISensor)
                    return (elem as BaseSensor).SensorValue;
                else if (elem is IActuator)
                    return (elem as BaseActuator).ActuatorValue;
                else
                    throw new NotImplementedException();
            }

            set
            {
                if (elem is ISensor) (elem as BaseSensor).SensorValue = value;
                else if (elem is IActuator) (elem as BaseActuator).ActuatorValue = value;
                else
                    throw new NotImplementedException();
                RaisePropertyChanged();

            }
        }

        public Daten(ISensor sensor)
        {
            elem = sensor as ItemBase;
        }

        public Daten(IActuator actuator)
        {
            elem = actuator as ItemBase;
        }

    }
}
