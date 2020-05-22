using System.Globalization;
using System.Linq;
using System.Threading;
using MultilingualXFSample.Resources;
using Xamarin.Forms;

namespace MultilingualXFSample.Views
{
    public partial class ChangeLanguagePage : ContentPage
    {
        public ChangeLanguagePage()
        {
            InitializeComponent();


        }

        void OnUpdateLangugeClicked(object sender, System.EventArgs e)
        {
            if (picker.SelectedItem != null)
            {
                var language= CultureInfo.GetCultures(CultureTypes.NeutralCultures).ToList().First(element => element.EnglishName.Contains(picker.SelectedItem.ToString())); ;
                Thread.CurrentThread.CurrentUICulture = language;
                AppResources.Culture = language;
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
        }
    }
}
