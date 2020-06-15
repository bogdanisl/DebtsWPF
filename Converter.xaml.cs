using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Debts
{
    /// <summary>
    /// Interaction logic for Converter.xaml
    /// </summary>
    public partial class Converter : Window
    {
        private double _eur;
        private double _usd;
        private double _rub;
        public Converter(Currencies currency,string theme)
        {
            InitializeComponent();
            _eur = currency.EUR;
            _usd = currency.USD;
            _rub = currency.RUB;
            eur.Text = currency.EUR.ToString();
            usd.Text = currency.USD.ToString();
            rub.Text = currency.RUB.ToString();
            SelectedCurrency.SelectedIndex = 0;
            if(theme=="Dark")
            {
                TopPanel.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                upDownUAH.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                upDownUSD.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                upDownEUR.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                upDownRUB.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                upDownUAH.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                upDownUSD.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                upDownEUR.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                upDownRUB.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                ButtonClose.Foreground = Brushes.White;
            }
            else if (theme == "Light")
            {
                TopPanel.Background = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));
                Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                Foreground = Brushes.Black;
                upDownUAH.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                upDownUSD.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                upDownEUR.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                upDownRUB.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                upDownUAH.Foreground = Brushes.Black;
                upDownUSD.Foreground = Brushes.Black;
                upDownEUR.Foreground = Brushes.Black;
                upDownRUB.Foreground = Brushes.Black;
                ButtonClose.Foreground = Brushes.Black;
            }
            else if (theme == "Violet")
            {
                TopPanel.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                Foreground = Brushes.White;
                upDownUAH.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                upDownUSD.Background =  new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                upDownEUR.Background =  new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                upDownRUB.Background =  new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                upDownUAH.Foreground = Brushes.White;
                upDownUSD.Foreground = Brushes.White;
                upDownEUR.Foreground = Brushes.White;
                upDownRUB.Foreground = Brushes.White;
                ButtonClose.Foreground = Brushes.White;
            }
            else if (theme == "Blue")
            {
                TopPanel.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                Foreground = Brushes.Black;
                upDownUAH.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                upDownUSD.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                upDownEUR.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                upDownRUB.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                upDownUAH.Foreground = Brushes.Black;
                upDownUSD.Foreground = Brushes.Black;
                upDownEUR.Foreground = Brushes.Black;
                upDownRUB.Foreground = Brushes.Black;
                ButtonClose.Foreground = Brushes.Black;
            }
        }

        private void upDownUAH_ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (SelectedCurrency.SelectedIndex == 0)
            {
                upDownEUR.Value = (upDownUAH.Value / _eur);
                upDownUSD.Value = (upDownUAH.Value / _usd);
                upDownRUB.Value = (upDownUAH.Value / _rub);
            }
        }

        private void upDownUSD_ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (SelectedCurrency.SelectedIndex == 1)
            {
                double? uah = upDownUSD.Value * _usd;
                upDownEUR.Value = (uah / _eur);
                upDownUAH.Value = uah;
                upDownRUB.Value = (uah / _rub);
            }
        }

        private void upDownEUR_ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (SelectedCurrency.SelectedIndex == 2)
            {
                double? uah = upDownEUR.Value * _eur;
                upDownUAH.Value = uah;
                upDownUSD.Value = (uah / _usd);
                upDownRUB.Value = (uah / _rub);
            }
        }

        private void upDownRUB_ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(SelectedCurrency.SelectedIndex==3)
            {
            double? uah = upDownRUB.Value * _rub;
            upDownEUR.Value = (uah / _eur);
            upDownUSD.Value = (uah / _usd);
            upDownUAH.Value = uah;
            }
        }

        private void SelectedCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(SelectedCurrency.SelectedIndex==0)
            {
                upDownUAH.IsEnabled = true;
                upDownUSD.IsEnabled = false;
                upDownEUR.IsEnabled = false;
                upDownRUB.IsEnabled = false;
            }
            else if (SelectedCurrency.SelectedIndex == 1)
            {
                upDownUAH.IsEnabled = false;
                upDownUSD.IsEnabled = true;
                upDownEUR.IsEnabled = false;
                upDownRUB.IsEnabled = false;
            }
            else if (SelectedCurrency.SelectedIndex == 2)
            {
                upDownUAH.IsEnabled = false;
                upDownUSD.IsEnabled = false;
                upDownEUR.IsEnabled = true;
                upDownRUB.IsEnabled = false;
            }
            else if (SelectedCurrency.SelectedIndex == 3)
            {
                upDownUAH.IsEnabled = false;
                upDownUSD.IsEnabled = false;
                upDownEUR.IsEnabled = false;
                upDownRUB.IsEnabled = true;
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
