using System.Windows;

namespace QuangKietWPF
{
    public partial class CustomerProfile : Window
    {
        public CustomerProfile()
        {
            InitializeComponent();
            DataContext = new ViewModels.CustomerProfileViewModel();
        }
    }
}