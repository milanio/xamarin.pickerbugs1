using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PickerBugs1.Models;
using Xamarin.Forms;

namespace PickerBugs1.ViewModels
{
    public class MonkeysViewModel : INotifyPropertyChanged
    {
        public DefaultMonkeyObservableCollection Monkeys { get; }=new DefaultMonkeyObservableCollection();
        
        public MonkeysViewModel()
        {
        }

        private DummyColor _ChosenColor;
        public DummyColor ChosenColor
        {
            get => _ChosenColor;
            set
            {
                if (_ChosenColor == value) return;
                _ChosenColor = value;
                OnPropertyChanged();
            }
        }

        private DummyColor _ChosenColor2;
        public DummyColor ChosenColor2
        {
            get => _ChosenColor2;
            set
            {
                if (_ChosenColor2 == value) return;
                _ChosenColor2 = value;
                OnPropertyChanged();
            }
        }

        private DummyColor _ChosenColorA;
        public DummyColor ChosenColorA
        {
            get => _ChosenColorA;
            set
            {
                if (_ChosenColorA == value) return;
                _ChosenColorA = value;
                OnPropertyChanged();
            }
        }

        private DummyColor _ChosenColorB;
        public DummyColor ChosenColorB
        {
            get => _ChosenColorB;
            set
            {
                if (_ChosenColorB == value) return;
                _ChosenColorB = value;
                OnPropertyChanged();
            }
        }

        private DummyColor _ChosenColorC;
        public DummyColor ChosenColorC
        {
            get => _ChosenColorC;
            set
            {
                if (_ChosenColorC == value) return;
                _ChosenColorC = value;
                OnPropertyChanged();
            }
        }

        private DummyColor _ChosenColorD;
        public DummyColor ChosenColorD
        {
            get => _ChosenColorD;
            set
            {
                if (_ChosenColorD == value) return;
                _ChosenColorD = value;
                OnPropertyChanged();
            }
        }


        private List<DummyColor> _allColors = new List<DummyColor>()
        {
            new DummyColor(){Name = "Red"},
            new DummyColor(){Name = "Blue"},
            new DummyColor(){Name = "Green"},
            new DummyColor(){Name = "Yellow"}
        };
        public List<DummyColor> AllColors
        {
            get => _allColors;
            set
            {
                if (_allColors == value) return;
                _allColors = value;
                OnPropertyChanged();
            }
        }



        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
