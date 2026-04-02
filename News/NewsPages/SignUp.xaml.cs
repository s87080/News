
namespace News.NewsPages;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();

	}
    //private async void Sign_In(object sender, EventArgs e)
    //{
    //	string username = name.Text;	
    //	string Email = email.Text;	
    //	string Phone = phone.Text;	
    //	string Password = password.Text;

    //	if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Password))
    //	{
    //		await DisplayAlert("Error", "Please fill in all fields.", "OK");
    //		return;
    //       }
    //       Preferences.Get("username", "");
    //       Preferences.Set("Email", Email);
    //       Preferences.Set("Phone", Phone);
    //       Preferences.Set("Password", Password);

    //	await DisplayAlert("Success", "You have successfully signed up!", "OK");
    //       await Navigation.PushAsync(new SignIn());
    //       SIGNIN(null,null);


    //   }
    private async void Sign_In(object sender, EventArgs e)
    {
        string username = name.Text;
        string Email = email.Text;
        string Phone = phone.Text;
        string Password = password.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(Email) ||
            string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Password))
        {
            await DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }

        Preferences.Set("username", username);
        Preferences.Set("email", Email);
        Preferences.Set("phone", Phone);
        Preferences.Set("password", Password);

        await DisplayAlert("Success", "Signup done!", "OK");

        await Navigation.PushAsync(new SignIn());
    }
}