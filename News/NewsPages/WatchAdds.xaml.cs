using System;
using Microsoft.Maui.Controls;

namespace News.NewsPages;

public partial class WatchAdds : ContentPage
{
    int coins = 0;

    public WatchAdds()
    {
        InitializeComponent();
    }

    private async void OnWatchAdClicked(object sender, EventArgs e)
    {
        coins += 10;
        await DisplayAlert("Success", "You earned 10 coins!", "OK");
    }

    private async void OnCheckBalanceClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Balance", $"Your coins: {coins}", "OK");
    }
}