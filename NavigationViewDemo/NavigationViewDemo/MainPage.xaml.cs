using Microsoft.Maui.Devices;

namespace NavigationViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Outbox");
            list.Add("Sent");
            list.Add("Draft");
            list.Add("Spam");
            list.Add("Saved");
            list.Add("Group");
            list.Add("People");
            list.Add("Delete");
            
            listView.ItemsSource = list;
            navigationView.TranslationX = DeviceDisplay.Current.MainDisplayInfo.Width;
        }

        private void TransferInClicked(object sender, EventArgs e)
        {
            navigationView.TranslationX = DeviceDisplay.Current.MainDisplayInfo.Width - 970;
        }

        private void TransferOutClicked(object sender, EventArgs e)
        {
            navigationView.TranslationX = DeviceDisplay.Current.MainDisplayInfo.Width;
        }

        private void TransferTo0_Clicked(object sender, EventArgs e)
        {
            navigationView.TranslationX = 0;
        }
    }

}
