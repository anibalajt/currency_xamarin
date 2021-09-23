using System;
using currency.Models;

namespace currency
{
    public class CurrencyService
    {
        Currency c = new Currency();

        private string total;
        public string Total
        {
            get
            {
                float d = c.Total;
                //check if the number is integer
                if (CheckNumber(d))
                {
                    //if it is integer, return without cent
                    return $"Total: ${d}";
                }
                else
                {
                    //if it is integer, return with cent
                    return $"Total: ${d.ToString("#.##")}c";
                }
            }
        }
        public string Totalone
        { 
            get
            {
                float d = c.oneDollar;
                //check if the number is integer
                if (CheckNumber(d))
                {
                    //if it is integer, return without cent
                    return $"${d}";
                }
                else
                {
                    //if it is integer, return with cent
                    return $"${d.ToString("#.##")}c";
                }
            }
        }
        public string TotalFifty
        {
            get
            {
                float d = c.fiftyCent;
                //check if the number is integer
                if (CheckNumber(d))
                {
                    //if it is integer, return without cent
                    return $"${d}";
                }
                else
                {
                    //if it is integer, return with cent
                    return $"${d.ToString("#.##")}c";
                }
            }
        }
        public string TotalTwenty
        {
            get
            {
                float d = c.twentyCent;
                //check if the number is integer
                if (CheckNumber(d))
                {
                    //if it is integer, return without cent
                    return $"${d}";
                }
                else
                {
                    //if it is integer, return with cent
                    return $"${d.ToString("#.##")}c";
                }
            }
        }
        public string TotalTen
        {
            get
            {
                float d = c.tenCent;
                //check if the number is integer
                if (CheckNumber(d))
                {
                    //if it is integer, return without cent
                    return $"${d}";
                }
                else
                {
                    //if it is integer, return with cent
                    return $"${d.ToString("#.##")}c";
                }
            }
        }
        public string TotalFive
        {
            get
            {
                float d = c.fiveCent;
                //check if the number is integer
                if (CheckNumber(d))
                {
                    //if it is integer, return without cent
                    return $"${d}";
                }
                else
                {
                    //if it is integer, return with cent
                    return $"${d.ToString("#.##")}c";
                }
            }
        }
        public CurrencyService()
        {
        }
        public void SubtractCoinAddUp(int typeCoin)
        {
            switch (typeCoin)
            {
                case 2:
                    if (c.fiftyCent > 0)
                    {
                        c.oneDollar = c.oneDollar + 0.50f;
                        c.fiftyCent = c.fiftyCent - 0.50f;
                    }
                   
                    break;
                case 3:
                    if (c.twentyCent > 0)
                    {
                        c.fiftyCent = c.fiftyCent + 0.20f;
                        c.twentyCent = c.twentyCent - 0.20f;
                    }
                    
                    break;
                case 4:
                    if (c.tenCent > 0)
                    {
                        c.twentyCent = c.twentyCent + 0.10f;
                        c.tenCent = c.tenCent - 0.10f;
                    }
                    
                    break;
                case 5:
                    if (c.fiveCent > 0)
                    {
                        c.tenCent = c.tenCent + 0.05f;
                        c.fiveCent = c.fiveCent - 0.05f;
                    }
                    
                    break;
            }
        }
        public void SubtractCoinAddDown(int typeCoin)
        {
            switch (typeCoin)
            {
                case 1:
                    if (c.oneDollar > 0)
                    {
                        c.oneDollar = c.oneDollar - 1;
                        c.fiftyCent = c.fiftyCent + 1;
                    }
                    
                    break;
                case 2:
                    if (c.fiftyCent > 0)
                    {
                        c.fiftyCent = c.fiftyCent - 0.50f;
                        c.twentyCent = c.twentyCent + 0.50f;
                    }
                    
                    break;
                case 3:
                    if (c.twentyCent > 0)
                    {
                        c.twentyCent = c.twentyCent - 0.20f;
                        c.tenCent = c.tenCent + 0.20f;
                    }
                    
                    break;
                case 4:
                    if (c.tenCent > 0)
                    {
                        c.tenCent = c.tenCent - 0.10f;
                        c.fiveCent = c.fiveCent + 0.10f;
                    }
                    
                    break;
                //case 5:
                //    c.fiveCent = c.fiveCent - 0.05f;
                //    break;
            }
        }
        public void SubtractCoin(int typeCoin)
        {
            switch (typeCoin)
            {
                case 1:
                    if (c.oneDollar > 0) {
                        c.oneDollar = c.oneDollar - 1;
                    }
                    break;
                case 2:
                    if (c.fiftyCent > 0)
                    {
                        c.fiftyCent = c.fiftyCent - 0.50f;
                    }
                    
                    break;
                case 3:
                    if (c.twentyCent > 0)
                    {
                        c.twentyCent = c.twentyCent - 0.20f;
                    }
                    
                    break;
                case 4:
                    if (c.tenCent > 0)
                    {
                        c.tenCent = c.tenCent - 0.10f;
                    }
                    
                    break;
                case 5:
                    if (c.fiveCent > 0)
                    {
                        c.fiveCent = c.fiveCent - 0.05f;
                    }
                    
                    break;
            }
        }
        public void AddCoin(int typeCoin)
        {
            switch (typeCoin)
            {
                case 1:
                    c.oneDollar = c.oneDollar + 1;
                    break;
                case 2:
                    c.fiftyCent = c.fiftyCent + 0.50f;
                    break;
                case 3:
                    c.twentyCent = c.twentyCent + 0.20f;
                    break;
                case 4:
                    c.tenCent = c.tenCent + 0.10f;
                    break;
                case 5:
                    c.fiveCent = c.fiveCent + 0.05f;
                    break;
            }
        }
        private bool CheckNumber(float d)
        {
            return unchecked(d == (int)d);
        }
    }
}
