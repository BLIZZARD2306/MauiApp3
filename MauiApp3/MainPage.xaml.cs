namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        async void OnDial(object sender, EventArgs e)
        {
            try
            {
                if (PhoneNum.Text.Any(char.IsLetter))
                {
                    throw new ArgumentException();
                }
                PhoneDialer.Open(PhoneNum.Text);
            }
            catch (Exception)
            {
                await DisplayAlertAsync("Invalid input", "Please enter a valid phone number", "OK");
            }
        }
    }
}
