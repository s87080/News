namespace News.NewsPages;

public partial class First : ContentPage
{
	public First()
	{
		InitializeComponent();
	}
	private void GetStarted(object sender, EventArgs e) {
		Navigation.PushAsync(new SignUp());
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
    }
}