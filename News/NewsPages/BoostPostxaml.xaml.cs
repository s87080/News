namespace News.NewsPages;

public partial class BoostPostxaml : ContentPage
{
	public BoostPostxaml()
	{
		InitializeComponent();
	}
    private async void BoostNow(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Booste Post Successfully ✅", "OK");
    }
}