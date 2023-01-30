using System;
using System.Globalization;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() =>
            {
                LocalizationResourceManager.Current.CurrentCulture =
                    LocalizationResourceManager.Current.CurrentCulture.TwoLetterISOLanguageName == "en" ?
                        new CultureInfo("uk") :
                        new CultureInfo("en");
            });
        }

        public ICommand OpenWebCommand { get; }
    }
}