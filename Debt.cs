using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace Debts
{
    public enum Currency { UAH, USD, EUR, RUB }
    [Serializable]
    public class Debt : INotifyPropertyChanged
    {
        private string name;
        private int sum;
        private int procent;
        private DateTime issue;
        private DateTime _return;
        private int sumUah;
        private bool isClosed;
        private bool isStarred;
        private bool isOut;
        private Currency currency;
        private bool datereturn;
        private int profit;
        private bool isGiven;
        private short selectedIndexCurrency;


        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        public int Sum
        {
            get { return sum; }
            set { sum = value; OnPropertyChanged(); Profit = Sum / 100 * Procent; }
        }
        public int Procent
        {
            get { return procent; }
            set { procent = value; OnPropertyChanged(); Profit = Sum / 100 * Procent; }
        }
        public DateTime Issue
        {
            get { return issue; }
            set { issue = value; OnPropertyChanged(); }
        }
        public DateTime Return
        {
            get { return _return; }
            set { _return = value; OnPropertyChanged(); if (value > DateTime.Now) { IsOut = false; } else IsOut = true; }
        }
        public int SumUAH
        {
            get { return sumUah; }
            set { sumUah = value; OnPropertyChanged(); }
        }
        public bool IsClosed
        {
            get { return isClosed; }
            set { isClosed = value; OnPropertyChanged(); OnPropertyChanged(nameof(IsClosedV)); }
        }
        public bool IsStarred
        {
            get { return isStarred; }
            set { isStarred = value; OnPropertyChanged(); OnPropertyChanged(nameof(IsStarredV)); }
        }
        public bool IsOut
        {
            get { return isOut; }
            set { isOut = value; OnPropertyChanged(); OnPropertyChanged(nameof(IsOutV)); }
        }
        public Currency Currency
        {
            get { return currency; }
            set
            {
                currency = value; OnPropertyChanged();
            }
        }
        public bool DateReturn
        {
            get { return datereturn; }
            set { datereturn = value; OnPropertyChanged(); OnPropertyChanged(nameof(ReturnDateV)); }
        }
        public int Profit
        {
            get { return profit; }
            set { profit = value; OnPropertyChanged(); }
        }
        public bool IsGiven
        {
            get { return isGiven; }
            set { isGiven = value; OnPropertyChanged(); }
        }


        public short SelectedIndexCurrency
        {
            get { return selectedIndexCurrency; }
            set
            {
                selectedIndexCurrency = value;
                if (value == 0)
                    Currency = Currency.UAH;
                else if (value == 1)
                    Currency = Currency.USD;
                if (value == 2)
                    Currency = Currency.EUR;
                if (value == 3)
                    Currency = Currency.RUB;
            }
        }

        public Visibility IsClosedV
        {
            get { if (IsClosed == true) { return Visibility.Visible; } else return Visibility.Hidden; }
        }
        public Visibility IsOutV
        {
            get { if (IsOut == true) { return Visibility.Visible; } else return Visibility.Hidden; }
        }
        public Visibility IsStarredV
        {
            get { if (IsStarred == true) { return Visibility.Visible; } else return Visibility.Hidden; }
        }
        public Visibility ReturnDateV
        {
            get { if (DateReturn == true) { return Visibility.Visible; } else return Visibility.Hidden; }
        }
        public Debt()
        {
            Currencies curRate = new Currencies();
            Name = "Name";
            Sum = 100;
            Procent = 5;
            Issue = DateTime.Now;
            Currency = Currency.EUR;
            IsClosed = false;
            IsStarred = false;
            DateReturn = false;
            IsGiven = false;
            SumUAH = 3000;
            Profit = Sum / 100 * Procent;
            Sum += Profit;
        }
        public Debt(string name, int sum, int procent, DateTime issue, DateTime _return, Currency currency, bool isGived)
        {
            Currencies curRate = new Currencies();
            Name = name;
            Sum = sum;
            Procent = procent;
            Issue = issue;
            Return = _return;
            Currency = currency;
            IsClosed = false;
            IsStarred = false;
            DateReturn = true;
            IsGiven = isGived;
            if (DateTime.Now > Return)
            {
                IsOut = true;
            }
            else
            {
                IsOut = false;
            }

            if (currency == Currency.UAH)
            {
                SumUAH = Sum;
                SelectedIndexCurrency = 0;
            }
            else if (currency == Currency.USD)
            {
                double sumD = Sum;
                SumUAH = (int)(sumD * curRate.USD);
                SelectedIndexCurrency = 1;
            }
            else if (currency == Currency.RUB)
            {
                double sumD = Sum;
                SumUAH = (int)(sumD * curRate.RUB);
                SelectedIndexCurrency = 3;
            }
            else if (currency == Currency.EUR)
            {
                double sumD = Sum;
                SumUAH = (int)(sumD * curRate.EUR);
                SelectedIndexCurrency = 4;
            }
            Profit = Sum / 100 * Procent;
            Sum += Profit;
        }
        public Debt(string name, int sum, int procent, DateTime issue, Currency currency, bool isGived)
        {
            Currencies curRate = new Currencies();
            Name = name;
            Sum = sum;
            Procent = procent;
            Issue = issue;
            Currency = currency;
            IsClosed = false;
            IsStarred = false;
            DateReturn = false;
            IsGiven = isGived;
            if (currency == Currency.UAH)
            {
                SumUAH = Sum;
                SelectedIndexCurrency = 0;
            }
            else if (currency == Currency.USD)
            {
                double sumD = Sum;
                SumUAH = (int)(sumD * curRate.USD);
                SelectedIndexCurrency = 1;
            }
            else if (currency == Currency.RUB)
            {
                double sumD = Sum;
                SumUAH = (int)(sumD * curRate.RUB);
                SelectedIndexCurrency = 3;
            }
            else if (currency == Currency.EUR)
            {
                double sumD = Sum;
                SumUAH = (int)(sumD * curRate.EUR);
                SelectedIndexCurrency = 2;
            }
            Profit = Sum / 100 * Procent;
            Sum += Profit;
            SelectedIndexCurrency = 0;
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
    public class Currencies
    {
        public double EUR { get; }
        public double USD { get; }
        public double RUB { get; }
        public Currencies()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("http://resources.finance.ua/ru/public/currency-cash.xml");
            XmlNode attr;
            XmlNode Node;
            for (int i = 1; i < 4; i++)
            {
                Node = xdoc.DocumentElement.SelectSingleNode($"organizations/organization[1]/currencies/c[{i}]");
                attr = Node.Attributes.GetNamedItem("br");
                string str = attr.Value;
                str = str.Replace('.', ',');
                if (EUR == 0)
                    EUR = double.Parse(str);
                else if (RUB == 0)
                {
                    RUB = double.Parse(str);
                }
                else if (USD == 0)
                {
                    USD = double.Parse(str);
                }
            }
        }
    }
}
