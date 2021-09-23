using System;
namespace currency.Models
{
    public class Currency
    {
        public float Total
        {
            get
            {
                return oneDollar + fiftyCent + twentyCent + tenCent + fiveCent;
            }
        }
        public float oneDollar { get; set; }
        public float fiftyCent { get; set; }
        public float twentyCent { get; set; }
        public float tenCent { get; set; }
        public float fiveCent { get; set; }

        public Currency()
        {
        }
    }
}
