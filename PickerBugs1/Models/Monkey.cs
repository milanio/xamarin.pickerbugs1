using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PickerBugs1.Annotations;

namespace PickerBugs1.Models
{
    public class Monkey : INotifyPropertyChanged
    {
        private string _name;
        private string _location;
        private string _details;
        private string _imageUrl;

        private DummyColor _SelectedColor;

        private List<DummyColor> _AllColors = new List<DummyColor>()
        {
            new DummyColor(){Name = "Red"},
            new DummyColor(){Name = "Blue"},
            new DummyColor(){Name = "Green"},
            new DummyColor(){Name = "Yellow"}
        };

        public string Name
        {
            get => _name;
            set
            {
                if (_name==value) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Location
        {
            get => _location;
            set
            {
                if (_location == value) return;
                _location = value;
                OnPropertyChanged();
            }
        }

        public string Details
        {
            get => _details;
            set
            {
                if (_details == value) return;
                _details = value;
                OnPropertyChanged();
            }
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                if (_imageUrl == value) return;
                _imageUrl = value;
                OnPropertyChanged();
            }
        }

        public DummyColor SelectedColor
        {
            get => _SelectedColor;
            set
            {
                if (_SelectedColor == value) return;
                _SelectedColor = value;
                OnPropertyChanged();
            }
        }

        public List<DummyColor> AllColors
        {
            get => _AllColors;
            set
            {
                if (_AllColors == value) return;
                _AllColors = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
