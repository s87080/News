namespace News.NewsPages;

public partial class AddPost : ContentPage
{
	public AddPost()
	{
		InitializeComponent();
	}
    private async void OnPostClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Post Added Successfully ✅", "OK");
    }
}