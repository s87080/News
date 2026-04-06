using News.Models;
using System.Collections.ObjectModel;

namespace News.NewsPages;

public partial class Notifications : ContentPage
{
    public ObservableCollection<NotificationModel> NotificationListData { get; set; }

    public Notifications()
    {
        InitializeComponent();

        NotificationListData = new ObservableCollection<NotificationModel>
        {
            new NotificationModel { Title="New Like ❤️", Message="Someone liked your post", Time="2 min ago"},
            new NotificationModel { Title="Comment 💬", Message="You got a new comment", Time="10 min ago"},
            new NotificationModel { Title="Post Approved ✅", Message="Your post has been approved", Time="1 hour ago"},
        };

        BindingContext = this;
    }
}