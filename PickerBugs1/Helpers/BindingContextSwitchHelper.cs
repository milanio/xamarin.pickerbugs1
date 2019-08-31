using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using PickerBugs1.ViewModels;
using PickerBugs1.Views.Examples;
using Xamarin.Forms;

namespace PickerBugs1.Helpers
{
    public static class BindingContextSwitchHelper
    {
        public static void SwitchContext(ContentPage contentPage, MonkeysViewModel monkeysVm)
        {
            var actionButton =
                contentPage.FindByName<Button>("ActionButton");
            if (contentPage.BindingContext != null)
            {
                contentPage.BindingContext = null;
                actionButton.Text = "And now set BindingContext back";
            }
            else
            {
                contentPage.BindingContext = monkeysVm;
                actionButton.Text = "Clear BindingContext";
            }
        }
    }
}
