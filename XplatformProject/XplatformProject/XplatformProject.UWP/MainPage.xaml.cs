using Windows.Foundation;

namespace XplatformProject.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new XplatformProject.App());
            Windows.UI.ViewManagement.ApplicationView.PreferredLaunchViewSize = new Size(300, 400);
            Windows.UI.ViewManagement.ApplicationView.PreferredLaunchWindowingMode = Windows.UI.ViewManagement.ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }
    }
}
