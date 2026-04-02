namespace News.NewsPages;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

    private void OnArrowTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MySetting());
    }
}