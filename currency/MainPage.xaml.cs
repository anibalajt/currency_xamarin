using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace currency
{
    public partial class MainPage : ContentPage
    {
        CurrencyService currencyService = new CurrencyService();

        public MainPage()
        {
            InitializeComponent();
            updateUI();
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            Console.WriteLine("OnSizeAllocated");
            base.OnSizeAllocated(width, height); //must be called
            if (width > height)
            {
                //containerView.Padding = new Thickness(40,10);
            }
            else
            {
                //containerView.Padding = new Thickness(10, 40);
            }
        }
        void BtnSubtractCoinAddUp_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.AutomationId);
            currencyService.SubtractCoinAddUp(id);
            updateUI();
        }
        void BtnSubtractCoinAddDown_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.AutomationId);

            currencyService.SubtractCoinAddDown(id);
            updateUI();
        }
        void BtnsubtractCoin_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.AutomationId);

            currencyService.SubtractCoin(id);
            updateUI();
        }
        void BtnAddCoin_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.AutomationId);

            currencyService.AddCoin(id);
            updateUI();
        }
        private void updateUI()
        {
            totalCurrency.Text = currencyService.Total;
            totalOneDollar.Text = currencyService.Totalone;
            totalFiftyCent.Text = currencyService.TotalFifty;
            totalTwentyCent.Text = currencyService.TotalTwenty;
            totalTenCent.Text = currencyService.TotalTen;
            totalFiveCent.Text = currencyService.TotalFive;
        }
    }
}
