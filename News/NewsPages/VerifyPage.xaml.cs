namespace News.NewsPages;

public partial class VerifyPage : ContentPage
{
	public VerifyPage()
	{
		InitializeComponent();
	}
	private void City(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SelectCity());
	}
}