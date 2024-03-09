using Library.Items;
using Library.Windows;
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

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseConnection connection = new DatabaseConnection();
        Dictionary<int, Member> members;
        Member member;
        Administrator admin;

        public MainWindow()
        {
            InitializeComponent();

            LoginUsernameTextBox.Focus();

            members = connection.GetMembersAsDictionary();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginAsMember();
            LoginAsAdmin();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.ShowDialog();
        }

        private bool CheckMember(out Member member)
        {
            member = null;

            foreach(Member m in members.Values)
            {
                if(m.Email.ToLower() == LoginUsernameTextBox.Text.ToLower() && m.Password == LoginPasswordBox.Password)
                {
                    member = m;
                    return true;
                }
            }
            return false;
        }

        private void LoginAsMember()
        {
            if (CheckMember(out member) && member != null)
            {
                MemberWindow memberWindow = new MemberWindow(connection, member);
                memberWindow.Show();
                this.Close();
            }
        }

        private void LoginAsAdmin()
        {
            if (LoginUsernameTextBox.Text == "admin" && LoginPasswordBox.Password == "password")
            {
                AdminWindow adminWindow = new AdminWindow(connection, admin);
                adminWindow.Show();
                this.Close();
            }
        }
    }
}