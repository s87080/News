namespace News.NewsPages;

using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

public partial class MySetting : ContentPage
{
	public MySetting()
	{
		InitializeComponent();
	}
    private void MyProfile(object sender, EventArgs e)
	{
        bool isSelected = false;

        isSelected = !isSelected;

        if (isSelected)
        {
            MyBorder.BackgroundColor = Color.FromArgb("#007BC0");
            
            MyBorder.Stroke = Color.FromArgb("#007BC0");
        }
        else
        {
            MyBorder.BackgroundColor = Colors.White;
            MyBorder.Stroke = Colors.Black;
        }
    
    Navigation.PushAsync(new Profile());
	}

    public async void logutpage(object sender,EventArgs e)
    {
        var sheet = new Pop();

        var result = await this.ShowPopupAsync(sheet);

        if (result is bool isLogout && isLogout)
        {
            
            await Navigation.PushAsync(new SignIn());
        }
    }
    private void OnWallet(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Wallet());
    }
    private void MyPostTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewsDetails());
    }
    private void BoostTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BoostPostxaml());
    }

}