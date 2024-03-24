using Library.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Library.Pages.AdminPages
{
    /// <summary>
    /// Interaction logic for MembersPage.xaml
    /// </summary>
    public partial class MembersPage : Page
    {
        ObservableCollection<Member> members;
        public MembersPage(ObservableCollection<Member> members)
        {
            InitializeComponent();

            this.members = members;
            membersDataGrid.ItemsSource = members;
        }
    }
}
