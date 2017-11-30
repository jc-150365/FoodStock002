﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FoodStock01
{
    public class MemoPage : ContentPage
    {
        public MemoPage(string title)
        {
            //タブに表示される文字列
            Title = title;

           /* //アイコン
            Icon = "memo.svg";*/

            //ラベルを生成
            var label1 = new Label
            {
                FontSize = 40,
                //ビューの中央に配置
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Text = title
            };

            Content = label1;
        }
    }
}