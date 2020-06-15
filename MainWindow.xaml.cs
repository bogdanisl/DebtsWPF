using Debts.Localizations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Debts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string account = "";
        public TextBox theme = new TextBox();
        public TextBox language = new TextBox();
        private DebtsViewModelData debts = new DebtsViewModelData();
        private Dictionary<string, string> accounts = new Dictionary<string, string>();
        private string _login;
        private string _pass;
        private bool isWindowMax;
        public object CurrenSelection { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            language.Text = "";
            theme.Text = Theme.Violet.ToString();
            groupBoxLogin.Style = null;
            groupBoxLogin.Background = Brushes.White;
            groupBoxLogin.BorderThickness = new Thickness(0);
            groupBoxStart.Style = null;
            groupBoxStart.BorderThickness = new Thickness(0);
            groupBoxStart.Visibility = Visibility.Visible;
            theme.TextChanged += Theme_TextChanged;
            theme.Text = Theme.Light.ToString();
            language.TextChanged += Language_TextChanged;
            isWindowMax = false;

            DataContext = debts;

            using (StreamReader sr = new StreamReader("Accounts.txt", Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    _login = sr.ReadLine();
                    _pass = sr.ReadLine();
                    if (!accounts.ContainsKey(_login))
                        accounts.Add(_login, _pass);
                }
            }
        }

        private void Language_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (language.Text == "Українська")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk");
            }
            if (language.Text == "English")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            }
            if (language.Text == "Français")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            }
            if (language.Text == "Deutsche")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
            }
            if (language.Text == "Čeština")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("cs");
            }
            if (language.Text == "Polska")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl");
            }
            if (language.Text == "Española")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
            }
            if (language.Text == "Italiano")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("it");
            }
            UpdateUI();
        }

        private void Theme_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (theme.Text == Theme.Blue.ToString())
            {
                foreach (var item in stackPanelLeft.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                        (item as Button).Foreground = Brushes.White;
                    }
                }
                foreach (var item in TopGrid.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                        (item as Button).Foreground = Brushes.White;
                    }
                }
                logoutButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                logoutButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                logoutButton.Foreground = Brushes.White;

                settingsButton.Foreground = Brushes.White;
                ButtonMinimize.Foreground = Brushes.White;
                ButtonFechar.Foreground = Brushes.White;
                ButtonMaximize.Foreground = Brushes.White;

                tabControl1.Background = new SolidColorBrush(Color.FromArgb(255, 101, 171, 238));
                tabControl1.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                GridLeft.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                TopLeftBorder.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                TopGrid.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                LogoLable.Foreground = Brushes.Black;

                labelWelcome.Foreground = Brushes.White;
                loginButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                loginButton.Foreground = Brushes.White;
                loginButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));

                registerButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                registerButton.Foreground = Brushes.White;
                registerButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));

                loginingButton.Background = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));
                loginingButton.Foreground = Brushes.White;
                loginingButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 21, 145, 247));

                usernameTextBox.Foreground = Brushes.Black;
                passwordTextBox.Foreground = Brushes.Black;
                confirmPasswordTextBox.Foreground = Brushes.Black;

                LogoLable.Foreground = Brushes.Black;
                groupBoxStart.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                borderStart.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));
                groupBoxLogin.Background = new SolidColorBrush(Color.FromArgb(255, 166, 219, 240));

                listBoxDebts.ItemTemplate = (DataTemplate)Resources["listTemplateBlue"];
                listBoxStarredDebts.ItemTemplate = (DataTemplate)Resources["listTemplateBlue"];
                listBoxClosedDebts.ItemTemplate = (DataTemplate)Resources["listTemplateBlue"];
                listBoxOutstandingDebts.ItemTemplate = (DataTemplate)Resources["listTemplateBlue"];
            }


            else if (theme.Text == Theme.Violet.ToString())
            {
                foreach (var item in stackPanelLeft.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));//
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                        (item as Button).Foreground = Brushes.White;
                    }
                }
                foreach (var item in TopGrid.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                        (item as Button).Foreground = Brushes.White;
                    }
                }
                logoutButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                logoutButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                logoutButton.Foreground = Brushes.White;

                settingsButton.Foreground = Brushes.White;
                ButtonMinimize.Foreground = Brushes.White;
                ButtonFechar.Foreground = Brushes.White;
                ButtonMaximize.Foreground = Brushes.White;

                LogoLable.Foreground = Brushes.Black;
                //tabControl1.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                tabControl1.Background = new SolidColorBrush(Color.FromArgb(255, 169, 126, 220));
                tabControl1.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                GridLeft.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                TopLeftBorder.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                TopGrid.Background = BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));

                labelWelcome.Foreground = Brushes.White;
                loginButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                loginButton.Foreground = Brushes.White;
                loginButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));

                registerButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                registerButton.Foreground = Brushes.White;
                registerButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));

                loginingButton.Background = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));
                loginingButton.Foreground = Brushes.White;
                loginingButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 133, 34, 189));

                usernameTextBox.Foreground = Brushes.Black;
                passwordTextBox.Foreground = Brushes.Black;
                confirmPasswordTextBox.Foreground = Brushes.Black;

                LogoLable.Foreground = Brushes.Black;
                groupBoxStart.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                borderStart.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));
                groupBoxLogin.Background = new SolidColorBrush(Color.FromArgb(255, 164, 111, 228));

                listBoxDebts.ItemTemplate = (DataTemplate)Resources["listTemplateViolet"];
                listBoxStarredDebts.ItemTemplate = (DataTemplate)Resources["listTemplateViolet"];
                listBoxClosedDebts.ItemTemplate = (DataTemplate)Resources["listTemplateViolet"];
                listBoxOutstandingDebts.ItemTemplate = (DataTemplate)Resources["listTemplateViolet"];
            }


            else if (theme.Text == Theme.Dark.ToString())
            {
                foreach (var item in stackPanelLeft.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                        (item as Button).Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                    }
                }
                foreach (var item in TopGrid.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                        (item as Button).Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                    }
                }
                logoutButton.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                logoutButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                logoutButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));

                settingsButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                ButtonMinimize.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                ButtonFechar.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                ButtonMaximize.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));

                TopGrid.Background = BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                tabControl1.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                tabControl1.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                GridLeft.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                TopLeftBorder.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));

                LogoLable.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));


                labelWelcome.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                loginButton.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                loginButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                loginButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));


                registerButton.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                registerButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                registerButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));

                loginingButton.Background = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));
                loginingButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 108, 120, 131));
                loginingButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 14, 22, 33));

                usernameTextBox.Foreground = Brushes.White;
                passwordTextBox.Foreground = Brushes.White;
                confirmPasswordTextBox.Foreground = Brushes.White;

                groupBoxStart.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                borderStart.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));
                groupBoxLogin.Background = new SolidColorBrush(Color.FromArgb(255, 23, 33, 43));


                listBoxDebts.ItemTemplate = (DataTemplate)Resources["listTemplateDark"];
                listBoxStarredDebts.ItemTemplate = (DataTemplate)Resources["listTemplateDark"];
                listBoxClosedDebts.ItemTemplate = (DataTemplate)Resources["listTemplateDark"];
                listBoxOutstandingDebts.ItemTemplate = (DataTemplate)Resources["listTemplateDark"];
            }


            else if (theme.Text == Theme.Light.ToString())
            {
                foreach (var item in stackPanelLeft.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                        (item as Button).Foreground = Brushes.Black;
                    }
                }
                foreach (var item in TopGrid.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                        (item as Button).BorderBrush = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                        (item as Button).Foreground = Brushes.Black;
                    }
                }
                logoutButton.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                logoutButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                logoutButton.Foreground = Brushes.Black;

                settingsButton.Foreground = Brushes.Black;
                ButtonMinimize.Foreground = Brushes.Black;
                ButtonFechar.Foreground = Brushes.Black;
                ButtonMaximize.Foreground = Brushes.Black;

                TopGrid.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                tabControl1.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));
                tabControl1.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                tabItemStarred.Foreground = Brushes.Black;
                tabItemClosed.Foreground = Brushes.Black;
                tabItemOutstanding.Foreground = Brushes.Black;
                GridLeft.Background = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));
                TopLeftBorder.Background = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));


                labelWelcome.Foreground = Brushes.Black;
                loginButton.Background = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));
                loginButton.Foreground = Brushes.Black;
                loginButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));

                registerButton.Background = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));
                registerButton.Foreground = Brushes.Black;
                registerButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));

                loginingButton.Background = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));
                loginingButton.Foreground = Brushes.Black;
                loginingButton.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 189, 195, 199));

                usernameTextBox.Foreground = Brushes.Black;
                passwordTextBox.Foreground = Brushes.Black;
                confirmPasswordTextBox.Foreground = Brushes.Black;

                LogoLable.Foreground = Brushes.Black;
                groupBoxStart.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                borderStart.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));
                groupBoxLogin.Background = new SolidColorBrush(Color.FromArgb(255, 236, 240, 241));

                listBoxDebts.ItemTemplate = (DataTemplate)Resources["listTemplateLight"];
                listBoxStarredDebts.ItemTemplate = (DataTemplate)Resources["listTemplateLight"];
                listBoxClosedDebts.ItemTemplate = (DataTemplate)Resources["listTemplateLight"];
                listBoxOutstandingDebts.ItemTemplate = (DataTemplate)Resources["listTemplateLight"];
            }
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            SafeInfo();
            this.Close();
        }

        private void TopGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            Settings settingsWindow = new Settings(language, theme);
            settingsWindow.Show();

        }
        private void Flipper_OnIsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            //System.Diagnostics.Debug.WriteLine("Card is flipped = " + e.NewValue);
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginButton.Content.ToString() == "Login")
            {
                loginButton.Content = "Registration";
                groupBoxLogin.Visibility = Visibility.Visible;
            }
            else
            {
                loginButton.Content = "Login";
                groupBoxLogin.Visibility = Visibility.Hidden;
            }
        }

        private void loginingButton_Click(object sender, RoutedEventArgs e)
        {
            if (accounts.ContainsKey(usernameTextBox.Text))
            {
                if (accounts[usernameTextBox.Text] == passwordTextBox.Password)
                {
                    account = usernameTextBox.Text;
                    groupBoxLogin.Visibility = Visibility.Hidden;
                    groupBoxStart.Visibility = Visibility.Hidden;
                    BinaryFormatter binFormat = new BinaryFormatter();
                    using (Stream fStream = File.Open($"{account}.txt", FileMode.OpenOrCreate))
                    {
                        if (fStream.Length > 0)
                        {
                            List<Debt> debtList = new List<Debt>();
                            debtList = ((List<Debt>)binFormat.Deserialize(fStream));
                            foreach (var item in debtList)
                            {
                                debts.AddDebt(item);
                            }
                            debtList.Clear();
                        }
                    }
                }
                else
                {
                    textBlockErrorLogin.Text = Strings.WrongPassword;
                }
            }
            else
            {
                textBlockErrorLogin.Text = Strings.UserNotFounded;
            }
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            groupBoxLogin.Visibility = Visibility.Visible;
            groupBoxStart.Visibility = Visibility.Visible;
            account = "";
            SafeInfo();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void createDebtButton_Click(object sender, RoutedEventArgs e)
        {
            debts.AddDebt(new Debt("", 0, 0, DateTime.Now, Currency.UAH, false));
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!accounts.ContainsKey(usernameTextBox.Text))
            {
                if (passwordTextBox.Password == confirmPasswordTextBox.Password)
                {
                    accounts.Add(usernameTextBox.Text, passwordTextBox.Password);
                    using (StreamWriter sw = new StreamWriter("Accounts.txt", true, Encoding.Default))
                    {
                        foreach (var item in accounts)
                        {
                            sw.WriteLine(item.Key);
                            sw.WriteLine(item.Value);
                        }
                    }
                    using (Stream fStream = File.Open($"{usernameTextBox.Text}.txt", FileMode.Create))
                    {
                    }
                    groupBoxLogin.Visibility = Visibility.Visible;
                }
                else
                {
                    textBlockErrorLogin.Text = Strings.PasswordDontMatch;
                }
            }
            else
            {
                textBlockErrorLogin.Text = Strings.UsernameAlreadyUsed;
            }
        }

        private void UpdateUI()
        {
            txtblock_Converter.Text = Strings.CurrencyConverter;
            txtblock_CreateDebt.Text = Strings.CreateDebt;
            txtblock_Logout.Text = Strings.Logout;
            txtblock_RemoveAll.Text = Strings.RemoveAllDebts;
            txtblock_Search.Text = Strings.Search;
            tabItemAll.Header = Strings.AllDebts;
            tabItemStarred.Header = Strings.Starred;
            tabItemClosed.Header = Strings.Closed;
            tabItemOutstanding.Header = Strings.Outstanding;
            loginButton.Content = Strings.Login;
            registerButton.Content = Strings.Register;
            loginingButton.Content = Strings.Login;

        }
        private void SafeInfo()
        {
            if (account == null || account == "")
            {

            }
            else
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                Stream fStream = File.Open($"{account}.txt", FileMode.Open);
                List<Debt> debtList = debts.ActingDebts.ToList();
                binFormat.Serialize(fStream, debtList);
                debtList.Clear();
                fStream.Close();
            }
        }

        private void removeAllButton_Click(object sender, RoutedEventArgs e)
        {
            debts.Clear();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            Search search = new Search(theme.Text, listBoxDebts);
            search.Show();
        }

        private void converterButton_Click(object sender, RoutedEventArgs e)
        {
            Converter converter = new Converter(new Currencies(), theme.Text);
            converter.Show();
        }

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (isWindowMax == false)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
            isWindowMax = !isWindowMax;
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (debts.SelectedDebt.IsStarred)
            {
                debts.AddStarredDebt(debts.SelectedDebt);
            }
            else
            {
                debts.RemoveStarredDebt(debts.SelectedDebt);
            }
        }

        private void CloseDebtToggleButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as ToggleButton).IsEnabled = false;
            debts.AddClosedDebt(debts.SelectedDebt);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            debts.RemoveDebt(debts.SelectedDebt);
        }
    }
    public enum Theme { Dark, Light, Blue, Violet };
}
