using ContactsKeeper.Core.DomainEntities;
using ContactsKeeper.Gui.MVVM;
using System.Collections.ObjectModel;

namespace ContactsKeeper.Gui.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        public RelayCommand AddCommand => new RelayCommand(execute => AddContact());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteContact(), canExecute => selectedContact != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Contacts = new ObservableCollection<Contact>();
        }

        private Contact selectedContact;
        public Contact SelectedContact
        {
            get { return selectedContact; }
            set 
            { 
                selectedContact = value;
                OnPropertyChanged();
            }
        }

        private void AddContact()
        {
            Contacts.Add(new Contact
            {
                Name = "Person1",
                Phone = "0000000000",
                Email = "Person1@gmail.com",
                Address = "N/A"
            });
        }

        private void DeleteContact()
        {
            Contacts.Remove(selectedContact);
        }

        private void Save()
        {
            // save to file/db
        }

        private bool CanSave()
        {
            // check whether can save or not
            // e.g is the database connected? does the logged in user have permission to save ? 
            return true;
        }
    }
}