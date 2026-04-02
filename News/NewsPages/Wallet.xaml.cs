using News.Models;
using System.Collections.ObjectModel;

namespace News.NewsPages;

public partial class Wallet : ContentPage

{
    public ObservableCollection<TransactionModel> Transactions { get; set; }

    public Wallet()
	{
		InitializeComponent();

        Transactions = new ObservableCollection<TransactionModel>
        {
            new TransactionModel
            {
                Title = "Added Money",
                Date = "Today",
                Amount = "+ ₹500",
                Type = "Credit",
                Icon = "money.png"
            },
            new TransactionModel
            {
                Title = "Subscription",
                Date = "Yesterday",
                Amount = "- ₹200",
                Type = "Debit",
                Icon = "subscription.png"
            },
            new TransactionModel
            {
                Title = "Recharge",
                Date = "10 Mar",
                Amount = "- ₹150",
                Type = "Debit",
                Icon = "recharge.png"
            },
            new TransactionModel
            {
                Title = "Cashback",
                Date = "08 Mar",
                Amount = "+ ₹100",
                Type = "Credit",
                Icon = "gift.png"
            }
        };

        BindingContext = this;
    }
}
