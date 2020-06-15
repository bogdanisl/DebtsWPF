using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Debts
{
    public class DebtsViewModelData
    {
        private ICollection<Debt> actingDebts = new ObservableCollection<Debt>();
        private ICollection<Debt> starredDebts = new ObservableCollection<Debt>();
        private ICollection<Debt> closedDebts = new ObservableCollection<Debt>();
        private ICollection<Debt> outstandingDebts = new ObservableCollection<Debt>();
        public IEnumerable<Debt> ActingDebts
        {
            get
            {
                return actingDebts;
            }
            set
            {
                actingDebts = (ICollection<Debt>)value;
            }
        }
        public IEnumerable<Debt> StarredDebts
        {
            get
            {
                return starredDebts;
            }
            set
            {
                starredDebts = (ICollection<Debt>)value;
            }
        }
        public IEnumerable<Debt> ClosedDebts
        {
            get
            {
                return closedDebts;
            }
            set
            {
                closedDebts = (ICollection<Debt>)value;
            }
        }
        public IEnumerable<Debt> OutstandingDebts
        {
            get
            {
                return outstandingDebts;
            }
            set
            {
                outstandingDebts = (ICollection<Debt>)value;
            }
        }
        public Debt SelectedDebt { get; set; }

        public void AddDebt(Debt debt)
        {
            if (debt.IsClosed)
            {
                closedDebts.Add(debt);
            }
            if (debt.IsStarred)
            {
                starredDebts.Add(debt);
            }
            if (debt.IsOut)
            {
                outstandingDebts.Add(debt);
            }
            actingDebts.Add(debt);
        }
        public void RemoveDebt(Debt debt)
        {
            actingDebts.Remove(debt);
            starredDebts.Remove(debt);
            closedDebts.Remove(debt);
            outstandingDebts.Remove(debt);
        }
        public void RemoveStarredDebt(Debt debt)
        {
            starredDebts.Remove(debt);
        }
        public void AddStarredDebt(Debt debt)
        {
            if(debt.IsStarred)
            {
                starredDebts.Add(debt);
            }
        }
        public void AddClosedDebt(Debt debt)
        {
            if(debt.IsClosed)
            {
                closedDebts.Add(debt);
            }
        }
        public void Clear()
        {
            actingDebts.Clear();
            starredDebts.Clear();
            closedDebts.Clear();
            outstandingDebts.Clear();
        }
    }
}
