using Plugin.Firebase.CloudMessaging;

namespace News.NewsPages;

public partial class SignIn : ContentPage
{
    public SignIn()
    {
        InitializeComponent();
    }
    private void Forget_Button(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Password());
    }
    private async void SIGNIN(object sender, EventArgs e)
    {
        {
#if ANDROID || IOS
            try
            {
                await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();

                var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();

                await Share.RequestAsync(new ShareTextRequest
                {
                    Text = token,
                    Title = "Share Token"
                });

                System.Diagnostics.Debug.WriteLine($"Firebase Token: {token}");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
#endif
        }

        string username = USERNAME.Text;
        string email = EMAIL.Text;
        string password = PASSWORD.Text;

        var savedUsername = Preferences.Get("username", "");
        var savedEmail = Preferences.Get("email", "");
        var savedPassword = Preferences.Get("password", "");

        if (username == savedUsername && email == savedEmail && password == savedPassword)
        {
            Preferences.Set("isLoggedIn", true);
            await DisplayAlert("Login Successfully", "Welcome to Dashboard", "Okey");
            Application.Current.Windows[0].Page = new AppShell();
        }
        else
        {
            await DisplayAlert("Login failed", "Invalid Password", "Okey");
        }

    }


    private void OnRegisterTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignUp());
    }
    
}