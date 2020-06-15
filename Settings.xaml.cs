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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        private readonly string[] languages = { "English", "Українська", "Français", "Deutsche", "Čeština", "Polska", "Española", "Italiano" };
        private short selectedLanguageIndx = 0;
        public Settings()
        {
            InitializeComponent();
        }

        private TextBox theme;
        private TextBox _Language;
        public Settings(TextBox language, TextBox theme)
        {
            InitializeComponent();
            _Language = language;
            this.theme = theme;
            if (language.Text != "")
                textBlockLanguage.Text = language.Text;
            else
                textBlockLanguage.Text = "English";
            if (language.Text == "Українська")
            {
                selectedLanguageIndx = 1;
            }
            if (language.Text == "English")
            {
                selectedLanguageIndx = 0;
            }
            if (language.Text == "Français")
            {
                selectedLanguageIndx = 2;
            }
            if (language.Text == "Deutsche")
            {
                selectedLanguageIndx = 3;
            }
            if (language.Text == "Čeština")
            {
                selectedLanguageIndx = 4;
            }
            if (language.Text == "Polska")
            {
                selectedLanguageIndx = 5;
            }
            if (language.Text == "Española")
            {
                selectedLanguageIndx = 6;
            }
            if (language.Text == "Italiano")
            {
                selectedLanguageIndx = 7;
            }
            if (theme.Text == Theme.Blue.ToString())
            {
                BlueTheme();
            }
            else if (theme.Text == Theme.Dark.ToString())
            {
                DarkTheme();
            }
            else if (theme.Text == Theme.Light.ToString())
            {
                LightTheme();
            }
            else if (theme.Text == Theme.Violet.ToString())
            {
                VioletTheme();
            }
        }
        private void violetThemeButton_Click(object sender, RoutedEventArgs e)
        {
            VioletTheme();
            theme.Text = Theme.Violet.ToString();
        }
        private void lightThemeButton_Click(object sender, RoutedEventArgs e)
        {
            LightTheme();
            theme.Text = Theme.Light.ToString();
        }
        private void blueThemeButton_Click(object sender, RoutedEventArgs e)
        {
            BlueTheme();
            theme.Text = Theme.Blue.ToString();
        }
        private void darkThemeButton_Click(object sender, RoutedEventArgs e)
        {
            DarkTheme();
            theme.Text = Theme.Dark.ToString();
        }
        private void DarkTheme()
        {
            violetThemeButton.Content = "";
            blueThemeButton.Content = "";
            darkThemeButton.Content = "✔";
            lightThemeButton.Content = "";
            textBlockLanguage.Background = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            changeLanguageButton.Background = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            changeLanguageButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            changeLanguageButton2.Background = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            changeLanguageButton2.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            okButton.Background = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            okButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 24, 27, 40));
            okButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
            changeLanguageButton2.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
            changeLanguageButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
            textBlockLanguage.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
            this.Background = new SolidColorBrush(Color.FromArgb(255, 53, 54, 58));
        }
        private void LightTheme()
        {
            violetThemeButton.Content = "";
            blueThemeButton.Content = "";
            darkThemeButton.Content = "";
            lightThemeButton.Content = "✔";
            textBlockLanguage.Background = Brushes.White;
            changeLanguageButton.Background = Brushes.White;
            changeLanguageButton.BorderBrush = Brushes.White;
            changeLanguageButton2.Background = Brushes.White;
            changeLanguageButton2.BorderBrush = Brushes.White;
            okButton.Background = Brushes.White;
            okButton.BorderBrush = Brushes.White;
            okButton.Foreground = Brushes.Black;
            changeLanguageButton2.Foreground = Brushes.Black;
            changeLanguageButton.Foreground = Brushes.Black;
            textBlockLanguage.Foreground = Brushes.Black;
            this.Background = new SolidColorBrush(Color.FromArgb(255, 238, 238, 238));

        }
        private void VioletTheme()
        {
            violetThemeButton.Content = "✔";
            blueThemeButton.Content = "";
            darkThemeButton.Content = "";
            lightThemeButton.Content = "";
            textBlockLanguage.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            changeLanguageButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            changeLanguageButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            changeLanguageButton2.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            changeLanguageButton2.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            okButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            okButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
            okButton.Foreground = Brushes.White;
            changeLanguageButton2.Foreground = Brushes.White;
            changeLanguageButton.Foreground = Brushes.White;
            textBlockLanguage.Foreground = Brushes.White;
            this.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
        }
        private void BlueTheme()
        {
            violetThemeButton.Content = "";
            blueThemeButton.Content = "✔";
            darkThemeButton.Content = "";
            lightThemeButton.Content = "";
            textBlockLanguage.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            changeLanguageButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            changeLanguageButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            changeLanguageButton2.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            changeLanguageButton2.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            okButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            okButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
            okButton.Foreground = Brushes.White;
            changeLanguageButton2.Foreground = Brushes.White;
            changeLanguageButton.Foreground = Brushes.White;
            textBlockLanguage.Foreground = Brushes.White;
            this.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
        }
        private void changeLanguageUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedLanguageIndx < 7)
            {
                selectedLanguageIndx++;
            }
            else if (selectedLanguageIndx == 7)
            {
                selectedLanguageIndx = 0;
            }
            textBlockLanguage.Text = languages[selectedLanguageIndx];
            _Language.Text = languages[selectedLanguageIndx];
        }
        private void settingsWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void changeLanguageButton2_Click(object sender, RoutedEventArgs e)
        {
            if (selectedLanguageIndx > 0)
            {
                selectedLanguageIndx--;
            }
            else if (selectedLanguageIndx == 0)
            {
                selectedLanguageIndx = 7;
            }
            textBlockLanguage.Text = languages[selectedLanguageIndx];
            _Language.Text = languages[selectedLanguageIndx];
        }
    }
}
