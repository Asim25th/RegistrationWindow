using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RegistrationWindow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateFreeAccountButton(object sender, RoutedEventArgs e)
        {
            AccountDetails accountDetails = new AccountDetails();
            accountDetails.NameOutput.Text = NameInput.Text;
            accountDetails.EmailAddressOutput.Text = EmailAddressInput.Text;
            accountDetails.PasswordOutput.Text = PasswordInput.Text;
            accountDetails.Show();
        }
    }
}