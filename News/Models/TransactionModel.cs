using System;
using System.Collections.Generic;
using System.Text;

namespace News.Models
{
    public class TransactionModel
    {
        public string Title { get; set; }        // Added Money / Subscription
        public string Date { get; set; }         // Today / 12 Mar
        public string Amount { get; set; }       // ₹500
        public string Type { get; set; }         // Credit / Debit
        public string Icon { get; set; }         // image path

        // Color auto change (🔥 important)
        public string AmountColor =>
            Type == "Credit" ? "Green" : "Red";
    }
}
