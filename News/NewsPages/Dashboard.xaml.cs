namespace News.NewsPages;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
	}
	private void Popular(object sender, EventArgs e)
	{
		Pop.TextColor = (Color)Application.Current.Resources["News"];
	}
	private void SeeResults(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NewsDetails());
	}

}