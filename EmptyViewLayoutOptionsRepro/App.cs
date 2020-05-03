using Xamarin.Forms;

namespace EmptyViewLayoutOptionsRepro
{
    public class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Markup_Experimental" });
            MainPage = new NavigationPage(new SelectionPage());
        }
    }
}
