using System;
using PickerBugs1.ViewModels;
using Xamarin.Forms;

namespace PickerBugs1.Views.Examples
{
    public partial class VerticalListPage : ContentPage
    {

        MonkeysViewModel mvvm = new MonkeysViewModel();
        public VerticalListPage()
        {
            InitializeComponent();
            BindingContext = mvvm;
        }

        protected override void OnBindingContextChanged()
        {

            base.OnBindingContextChanged();
        }

        private void ActionButton_OnClicked(object sender, EventArgs e)
        {
            if (BindingContext == null) BindingContext = mvvm;
            else BindingContext = null; //new MonkeysViewModel();
        }
    }
}
