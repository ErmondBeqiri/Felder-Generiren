using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace classe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            hinzufuegen();
        }

        FeldGenerrirenm[] feldgeneriren = new FeldGenerrirenm[9];

        public void hinzufuegen()
        {
            for (int i = 0; i < 9; i++)
            {
                feldgeneriren[i] = new FeldGenerrirenm();
                Box1.Children.Add(feldgeneriren[i].Button);
            }
        }
    }
}