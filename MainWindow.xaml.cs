using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace register_login_blank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoginGrid.DataContext = new LoginViewModel();
            RegisterGrid.DataContext = new RegisterViewModel();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class LoginViewModel
    {
        public LoginData LoginData { get; set; }

        public LoginViewModel()
        {
            LoginData = new LoginData();
        }
    }

    public class RegisterViewModel
    {
        public RegisterData RegisterData { get; set; }

        public RegisterViewModel()
        {
            RegisterData = new RegisterData();
        }
    }
 
    public class LoginData
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class RegisterData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsDataSharedOnline { get; set; }
    }
}
    