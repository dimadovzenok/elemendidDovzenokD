﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace elemendidDovzenokD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Datapicker : ContentPage
    {
        Label label;
        DatePicker datePicker;
        public Datapicker()
        {
            label = new Label { Text = "Выберите дату", FontSize = 22, BackgroundColor = Color.WhiteSmoke };
            datePicker = new DatePicker
            {
                Format = "D"
            };
            datePicker.DateSelected += DatePicker_DateSelected;
            StackLayout stack = new StackLayout { Children = { label, datePicker } };
            stack.BackgroundColor = Color.IndianRed;
            this.Content = stack;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
            if (e.NewDate.ToString("dd/MM/yyyy") == "31/12/2020")
            {
                label.Text = "Вы выбрали новый год";
            }
            if (e.NewDate.ToString("dd/MM/yyyy") == "01/04/2021")
            {
                label.Text = "Вы выбрали первое апреля";
            }
        }
    }
}