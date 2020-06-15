using Debts.Localizations;
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        ListBox debts;
        public Search(string theme, ListBox debts)
        {
            InitializeComponent();
            this.debts = debts;
            FindButton.Content = Strings.Search;
            if(theme=="Light")
            {
                FindButton.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                FindButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                FindButton.Foreground = Brushes.Black;
                Exit.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                Exit.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                Exit.Foreground = Brushes.Black;
                nameTextBox.Foreground = Brushes.Black;
                Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
            }
            else if(theme == "Dark")
            {
                FindButton.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                FindButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                FindButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                Exit.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                Exit.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                Exit.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                nameTextBox.Foreground = Brushes.White;
                Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
            }
            else if (theme == "Violet")
            {
                FindButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                FindButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                FindButton.Foreground = Brushes.White;
                Exit.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                Exit.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                Exit.Foreground = Brushes.White;
                nameTextBox.Foreground = Brushes.White;
                Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
            }
            else if (theme == "Blue")
            {
                FindButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                FindButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                FindButton.Foreground = Brushes.White;
                Exit.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                Exit.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                Exit.Foreground = Brushes.White;
                nameTextBox.Foreground = Brushes.White;
                Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
            }
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in debts.Items)
            {
                if((item as Debt).Name==nameTextBox.Text)
                {
                    debts.SelectedItem = item;
                }
            }
        }
    }
}
