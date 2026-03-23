namespace News.NewsPages;

public partial class Password : ContentPage
{
	public Password()
	{
		InitializeComponent();
	}
	private void verify(object sender, EventArgs e)
	{
		Navigation.PushAsync(new VerifyPage());
	}
}