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

namespace Library.Pages.MemberPages
{
    /// <summary>
    /// Interaction logic for FavoritesPage.xaml
    /// </summary>
    public partial class FavoritesPage : Page
    {
        MemberWindow memberWindow;
        BookInfoPage bookInfoPage;

        Book book;
        ObservableCollection<Book> favorites;

        public FavoritesPage(MemberWindow memberWindow, BookInfoPage bookInfoPage, ObservableCollection<Book> favorites)
        {
            InitializeComponent();

            this.memberWindow = memberWindow;
            this.bookInfoPage = bookInfoPage;
            this.favorites = favorites;

            favoritesDataGrid.ItemsSource = favorites;
        }

        private void favoritesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (favoritesDataGrid.SelectedItem != null)
            {
                book = favorites[favoritesDataGrid.SelectedIndex];
                favoritesDataGrid.SelectedItem = null;
                bookInfoPage.GetCurrentBook(book);
                memberWindow.ShowBookInfoFrame();
            }
        }

        public void RefreshFavorites()
        {
            favoritesDataGrid.ItemsSource = null;
            favoritesDataGrid.ItemsSource = favorites;
        }
    }
}
