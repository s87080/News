using System;
using Microsoft.Maui.Controls;

namespace News.NewsPages;

public partial class Refer : ContentPage
{
    public Refer()
    {
        InitializeComponent();
    }

    private async void OnWatchAdClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ad", "Ad started... (Integrate AdMob here)", "OK");
    }

    private async void OnRunClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Run", "Running action executed 🚀", "OK");
    }
}