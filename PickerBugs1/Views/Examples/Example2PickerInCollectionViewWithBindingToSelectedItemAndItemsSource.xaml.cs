using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickerBugs1.Helpers;
using PickerBugs1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickerBugs1.Views.Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Example2PickerInCollectionViewWithBindingToSelectedItemAndItemsSource : ContentPage
    {
        readonly MonkeysViewModel _monkeysVm = new MonkeysViewModel();

        public Example2PickerInCollectionViewWithBindingToSelectedItemAndItemsSource()
        {
            InitializeComponent();
            BindingContext = _monkeysVm;
        }
        private void ActionButton_OnClicked(object sender, EventArgs e)
        {
            BindingContextSwitchHelper.SwitchContext(this, _monkeysVm);
        }

    }
}