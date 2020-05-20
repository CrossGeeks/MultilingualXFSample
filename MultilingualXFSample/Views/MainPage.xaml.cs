using System.ComponentModel;
using MultilingualXFSample.Resources;
using MultilingualXFSample.Views;
using Xamarin.Forms;

namespace MultilingualXFSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeLanguagePage());
        }
    }
}
