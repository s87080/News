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
    private void SIGNIN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dashboard());
    }
    private void OnRegisterTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignUp());
    }
    
}