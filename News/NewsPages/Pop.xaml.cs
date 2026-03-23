using CommunityToolkit.Maui.Views;

namespace News.NewsPages;

public partial class Pop : Popup
{
	public Pop()
	{
        InitializeComponent();
	}

	public async void OnCloseButtonClicked(object sender,EventArgs e)
	{
        this.Close(true); 

        
    }
}