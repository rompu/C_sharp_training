using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionTesting
{
    public class Model : INotifyPropertyChanged
    { //Testing if the view gets notified when an item in a collection changes
        private bool nameChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        //In this case the collection does notify the view when a name in the list is changed
        public Model()
        {
            Names = new ObservableCollection<string>() { "Antti", "Janne", "Vesa", "Kristoffer" };
            Positions = new ObservableCollection<DisplayMember>();
            Names.CollectionChanged += Names_CollectionChanged;
            Positions.CollectionChanged += Positions_CollectionChanged;
            Names.Insert(0, "sagf");
            Positions.Add(new DisplayMember { Position = "Developer" });
            Positions.Add(new DisplayMember { Position = "Manager" });
        }

        private void Positions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach(var newItem in e.NewItems)
            {
                if (newItem is INotifyPropertyChanged aa)
                    aa.PropertyChanged += Aa_PropertyChanged;
            }

            if (e.OldItems == null)
                return;

            foreach (var oldItem in e.OldItems)
            {
                if (oldItem is INotifyPropertyChanged aa)
                    aa.PropertyChanged -= Aa_PropertyChanged;
            }
        }

        private void Aa_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PositionsCollectionHasChanged = true;
        }

        private void Names_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CollectionHasChanged = true;
        }

        public ObservableCollection<string> Names { get; set; }

        public ObservableCollection<DisplayMember> Positions { get; set; }

        public bool CollectionHasChanged { get => nameChanged;
            set { nameChanged = value;
                OnPropertyChanged(nameof(CollectionHasChanged));
            }
        }

        public bool PositionsCollectionHasChanged
        {
            get => nameChanged;
            set
            {
                nameChanged = value;
                OnPropertyChanged(nameof(PositionsCollectionHasChanged));
            }

        }

        internal void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class DisplayMember : INotifyPropertyChanged
    {
        private string position;

        public override bool Equals(object obj)
        {
            if (obj is DisplayMember member)
                return member.Position == Position;
            return false;
        }

        public string Position { 
            get => position; 
            set { position = value;
                OnPropertyChanged(nameof(Position));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
