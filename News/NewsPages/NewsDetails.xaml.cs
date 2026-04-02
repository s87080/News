namespace News.NewsPages;

public partial class NewsDetails : ContentPage
{
	public NewsDetails()
	{
		InitializeComponent();
	}

	private void OnArrowTapped(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Dashboard());
	}

	
}