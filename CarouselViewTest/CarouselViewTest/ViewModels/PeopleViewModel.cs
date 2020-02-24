using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using CarouselViewTest.Models;
using Xamarin.Forms;

namespace CarouselViewTest.ViewModels
{
    internal class PeopleViewModel : INotifyPropertyChanged
    {
        private Person _currentPerson;
        private ObservableCollection<Person> _people;
        private int _position;

        public PeopleViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person {Age = 23, Name = "Steven"},
                new Person {Age = 53, Name = "Megan"},
                new Person {Age = 16, Name = "Joe"},
                new Person {Age = 67, Name = "Josh"},
                new Person {Age = 33, Name = "Jessica"},
                new Person {Age = 29, Name = "Jack"}
            };

            //This prevents the CurrentPerson from being null (the view does not set it initially and it causes other issues)
            //CurrentPerson = People.FirstOrDefault();
        }

        public Person CurrentPerson
        {
            get => _currentPerson;
            set
            {
                if (value == _currentPerson) return;
                _currentPerson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Person> People
        {
            get => _people;
            set
            {
                if (Equals(value, _people)) return;
                _people = value;
                OnPropertyChanged();
            }
        }

        public int Position
        {
            get => _position;
            set
            {
                if (value == _position) return;
                _position = value;
                OnPropertyChanged();
            }
        }

        public Command GoNextCommand => new Command(() =>
        {
            if (People.Count - 1 != Position)
            {
                Position++;

                //var newPerson = People[People.IndexOf(CurrentPerson) + 1];

                //CurrentPerson = newPerson;
            }
        });

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
