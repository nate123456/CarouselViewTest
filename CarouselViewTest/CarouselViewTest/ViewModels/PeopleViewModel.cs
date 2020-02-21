using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CarouselViewTest.Annotations;
using CarouselViewTest.Models;
using Xamarin.Forms;

namespace CarouselViewTest.ViewModels
{
    internal class PeopleViewModel : INotifyPropertyChanged
    {
        private int _position;
        private ObservableCollection<Person> _people;

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
        }

        public ObservableCollection<Person> People
        {
            get => _people;
            set
            {
                if (Equals(value, _people)) return;
                _people = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(GoNextCommand));
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
                OnPropertyChanged(nameof(GoNextCommand));
            }
        }

        public Command GoNextCommand => new Command(() =>
        {
            if (People.Count - 1 != Position)
                Position++;
        });

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
