using ContactsKeeper.Gui.ViewModel;
using System.Windows;

namespace ContactsKeeper.Gui
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}