﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodStock01;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        String s = "http://cookpad.com/search/";

        public FoodPage1(string title)
        {
            //タイトル
            Title = title;

            InitializeComponent();
        }

        /***試し***/
        public FoodPage1(int insert)
        {
            if(insert == 1)
            {
                InitializeComponent();
            }
        }
        /***試し***/

        void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            {
                s += ((CheckBox)sender).Text + "　";
                //DisplayAlert("URL", s, "ok");
            }
            //選択が外された時の処理
            else
            {
                s = s.Replace(((CheckBox)sender).Text +"　", "");
                //DisplayAlert("URL", s, "ok");
            }
        }

        /*void OnButtonClicked(object sender, EventArgs e)
        {
            s += ((Button)sender).Text + "　";
            DisplayAlert("URL", s, "ok");
        }

        public class ButtonAndString
        {
            public Button B { set; get; }
            public String S { set; get; }
        }*/

        void OnSearch_Clicked(object sender, EventArgs args)
        {
            //ページ遷移
            Navigation.PushAsync(new NextPage(s));
        }

    }
}