namespace News.NewsPages;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();

	}
	private void Sign_In(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Dashboard());
	}
}