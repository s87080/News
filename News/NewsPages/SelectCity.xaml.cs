using News.Models;
using System.Collections.ObjectModel;

namespace News.NewsPages;

public partial class SelectCity : ContentPage
{
	public SelectCity()
	{
		InitializeComponent();
		date();

    }

	public void date()
	{
		var data = new ObservableCollection<CityModel>
		{
			new CityModel{ CityName ="Delhi"},
			new CityModel{ CityName = "Mumbai"},
			new CityModel{ CityName ="Kolkata"},
			new CityModel{ CityName ="Bangalore"},
			new CityModel{ CityName ="Kochi"},
			new CityModel{ CityName ="Noida"},
			new CityModel{ CityName ="Delhi"},
			new CityModel{ CityName ="Mumbai"},
			new CityModel{ CityName ="Kolkata"},
			new CityModel{ CityName ="Bangalore"},
			new CityModel{ CityName ="Kochi"},
			new CityModel{ CityName ="Noida"},
			new CityModel{ CityName ="Delhi"},
			new CityModel{ CityName ="Bangalore"},
			new CityModel{ CityName ="Delhi"},
			new CityModel{ CityName ="Kochi"},
			new CityModel{ CityName ="Noida"},
			new CityModel{ CityName ="Bangalore"},
			new CityModel{ CityName ="Delhi"},
			new CityModel{ CityName ="Noida"},
			new CityModel{ CityName ="Delhi"},
			new CityModel{ CityName ="Kochi"},
			new CityModel{ CityName ="Noida"},
			new CityModel{ CityName ="Bangalore"},
			new CityModel{ CityName ="Delhi"}
		};
		CityData.ItemsSource = data;

    }
	private void Next(Object sender, EventArgs e)
	{
		Navigation.PushAsync(new Dashboard());
	}
}