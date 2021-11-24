using POS_FYP.Screens;
using System.Windows;



namespace POS_FYP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string email;
        private string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStyle = WindowStyle.SingleBorderWindow;
            this.ResizeMode = ResizeMode.NoResize;
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            email = tbEmail.Text;
            password = tbPassword.Text;

            VerifyUser(email, password);

        }

        //TODO
        private void VerifyUser(string email, string password) {

            if (email == "admin" && password == "admin")
            {
                Login();
            }
            else
            {
                MessageBox.Show("Invalid login credentials");
            }
        }

        private void Login()
        {
            Dashboard db = new Dashboard();
            db.Show();

            Close();
        }
    }
}
