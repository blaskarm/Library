using Library.Items;
using Library.Windows;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Pages.MemberPages
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        MemberWindow memberWindow;

        DatabaseConnection connection;

        Member member;

        public SettingsPage(MemberWindow memberWindow, DatabaseConnection connection, Member member)
        {
            InitializeComponent();

            this.memberWindow = memberWindow;
            this.connection = connection;
            this.member = member;

            this.DataContext = member;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeName();
            ChangeEmail();
            ChangePassword();
            RefreshDataContext();
            RefreshTextBoxes();
        }

        private void ChangeName()
        {
            if (changeName.Text != "")
            {
                member.FullName = changeName.Text;
                connection.SaveMemberName(member.Id, member.FullName);
                memberWindow.RefreshDataContext();
            }
        }

        private void ChangeEmail()
        {
            if (changeEmail.Text != "")
            {
                member.Email = changeEmail.Text;
                connection.SaveMemberEmail(member.Id, member.Email);
                memberWindow.RefreshDataContext();
            }
        }

        private void ChangePassword()
        {
            if (newPassword.Text != "")
            {
                member.Password = newPassword.Text;
                connection.SaveMemberPassword(member.Id, member.Password);
                memberWindow.RefreshDataContext();
            }
        }

        private void RefreshDataContext()
        {
            this.DataContext = null;
            this.DataContext = member;
        }

        private void RefreshTextBoxes()
        {
            changeName.Text = "";
            changeEmail.Text = "";
            newPassword.Text = "";
            confirmPassword.Text = "";
        }
    }
}
