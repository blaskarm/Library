using Library.Items;
using Library.Windows;
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
    /// Interaction logic for BorrowedPage.xaml
    /// </summary>
    public partial class BorrowedPage : Page
    {
        AdminWindow adminWindow;
        BookInfoPage bookInfoPage;

        Book book;
        ObservableCollection<Book> borrowed;

        public BorrowedPage(AdminWindow adminWindow, BookInfoPage bookInfoPage, ObservableCollection<Book> borrowed)
        {
            InitializeComponent();

            this.adminWindow = adminWindow;
            this.bookInfoPage = bookInfoPage;
            this.borrowed = borrowed;

            borrowedDataGrid.ItemsSource = borrowed;
        }

        private void borrowedDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (borrowedDataGrid.SelectedItem != null)
            {
                book = borrowed[borrowedDataGrid.SelectedIndex];
                borrowedDataGrid.SelectedItem = null;
                //bookInfoPage.GetCurrentBook(book);
                adminWindow.ShowBookInfoFrame();
            }
        }
    }
}
