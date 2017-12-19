using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StockPage1 : ContentPage
	{
		public StockPage1 (string title)
		{
            //タブに表示される文字列
            Title = title;

            InitializeComponent ();
		}

        //更新ボタンが押された時
        private void Update_Button_Clicked(object sender, EventArgs e)
        {
            Title = "保存";

            InitializeComponent();

        }

        //プラスがクリックされた
        void OnPlus_Clicked(object sender, EventArgs args)
        {
            string no = ((CustomButton)sender).NoText;
            string name = ((CustomButton)sender).NameText;
            int num = Convert.ToInt32(((CustomButton)sender).CountText);
            string unit = ((CustomButton)sender).UnitText;

            //DisplayAlert("1足しました", no+"　"+num.ToString(), "ok");

            int s_no = int.Parse(no);//
            /***ここから試し***/
            StockFoodModel.UpdateStockPlus02(s_no,name,num,unit);

            Title = "保存";

            InitializeComponent();
            /***ここまで試し***/
        }

        //マイナスがクリックされた
        void OnMinus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((CustomButtonMinus)sender).CountText) - 1;
            string name = ((CustomButtonMinus)sender).NameText;
            DisplayAlert("1引きました", name+"　"+num.ToString(), "ok");
        }
    }
}