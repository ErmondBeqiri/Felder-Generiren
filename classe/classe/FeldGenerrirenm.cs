using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace classe
{
    class FeldGenerrirenm
    {
        Button button = new Button();

        public Button Button
        {
            get
            {
                return button;

            }
            set
            {


                button = value;
            }


        }
        public FeldGenerrirenm()
        {
            button.Width = 80;
            button.Height = 80;
            button.Background = new SolidColorBrush(Colors.Black);
            button.FontFamily = new FontFamily("Papyrus");
            button.FontSize = 30;
            button.BorderBrush = Brushes.White;
            button.BorderThickness = new Thickness(2, 2, 2, 2);
            button.Content = "";


        }

    }
}

