
using News.Models;
using System.Collections.ObjectModel;


namespace News.NewsPages;


public partial class Home : ContentPage

{
    public ObservableCollection<Hastags> HashtagsList { get; set; }

    public Home()
    {
        InitializeComponent();
        LoadData();
        TempData();
        Temp();
    }
    public void LoadData()
    {
        var data = new ObservableCollection<Hastags>
        {
            new Hastags { HastagsName = "#FridayMorning" },
            new Hastags { HastagsName = "#CollegeDay" },
            new Hastags { HastagsName = "#InstagramDown" },
            new Hastags { HastagsName = "#FridayFeeling" },
            new Hastags { HastagsName = "#thrusdayVibes" },
            new Hastags { HastagsName = "#DigitalCurrency" },
            new Hastags { HastagsName = "#Bitcoin" },
            new Hastags { HastagsName = "#Cryptocurrency" },
        };
        HasData.ItemsSource = data;
    }

    public void TempData()
    {
        var data = new ObservableCollection<LatestNews>
        {
            new LatestNews{ Image ="snow.jpg", Title = "Climate change: Arctic warming linked to colder winters", Channels= "Nature Channel"},
            new LatestNews{ Image ="snow.jpg", Title = "Climate change: Arctic warming linked to colder winters", Channels= "Nature Channel"},
            new LatestNews{ Image ="snow.jpg", Title = "Climate change: Arctic warming linked to colder winters", Channels= "Nature Channel"},
            new LatestNews{ Image ="snow.jpg", Title = "Climate change: Arctic warming linked to colder winters", Channels= "Nature Channel"}
        };
        NewsData.ItemsSource = data;
    }
    public void Temp()
    {
        var data = new ObservableCollection<Channels>
        {
            new Channels{ Image ="job", Title = "US jobs growth disappoints as recovery falters", Channel= "Nature Channel"},
            new Channels{ Image ="fruits.jpg", Title = "Food price rise fears amid staff shortages", Channel= "Nature Channel"},
            new Channels{ Image ="snow.jpg", Title = "Climate change: Arctic warming linked to colder winters", Channel= "Nature Channel"},
            new Channels{ Image ="job.jpg", Title = "US jobs growth disappoints as recovery falters", Channel= "Nature Channel"}
        };

        topics.ItemsSource = data;

    }

    private void goo(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MySetting());
    }
}