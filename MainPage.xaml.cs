using Microsoft.Maui.Graphics.Converters;
using Notepad__easy_.ViewModel;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Communication = Microsoft.Maui.ApplicationModel.Communication;


namespace Notepad__easy_
{
    public partial class MainPage : ContentPage
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SearchButtonPressed { private set; get; }
        Label resultsLabel;
        SearchBar searchBar;

        private static Color CreateColor()
        {
            var random = new Random();
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));

            return new Color(r, g, b);
        }

        // This function should be renamed to CreateNewNotes;
        // there needs to be a new function that occurs when you open a preexisting note...
        private void OpenNote(object sender, EventArgs e) 
        {
            // Click event works (Confirmed)

        }
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            Notes.BackgroundColor = CreateColor();
            BindingContext = vm;

        }

        // delete this
        private void test(object sender, EventArgs e)
        {
            DeleteBtn.BackgroundColor = CreateColor();

        }


        // This crashes the program, should probably remove it...
        // Also does not work, as the deselection is not working

        private void ShowMore(object sender, EventArgs e)
        {
            // Click event works (Confirmed)
            if (MoreBtns.IsVisible == false)
            {
                MoreBtns.IsVisible = true;
            }
            else
            {
                MoreBtns.IsVisible = false;
            }

            //MoreBtns.BackgroundColor = Colors.LightGray;


        }

        private void PressedBtn(object sender, EventArgs e)
        {
            // Click event works (Confirmed)
            

        }
        private void ReleasedBtn(object sender, EventArgs e)
        {
            // Click event works (Confirmed)
            

        }

        // set height directly or find handler then set winHeight
        //int winWidth = 450;

        //public class SearchViewModel : INotifyPropertyChanged
        //{
        //    public event PropertyChangedEventHandler PropertyChanged;

        //    protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }

        //    public ICommand PerformSearch => new Command<string>((string query) =>
        //    {
        //        SearchResults = DataService.GetSearchResults(query);
        //    });

        //    private List<string> searchResults = DataService.Fruits;
        //    public List<string> SearchResults
        //    {
        //        get
        //        {
        //            return searchResults;
        //        }
        //        set
        //        {
        //            searchResults = value;
        //            NotifyPropertyChanged();
        //        }
        //    }
        //}
        void OnTextChanged(object sender, EventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            //searchResults.ItemsSource = DataQuery.GetSearchResults(searchBar.Text);
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        //private void SearchBar_TextChanged(object sender, EventArgs e)
        //{
        //    var search = SearchBar.Search(((SearchBar)sender).Text);

        //}
        //public static List<SearchBar> Search(string filterText)
        //{ 

        //}
        //private void HandleSearchPressed(string searchText)
        //{
        //    LabelTextPress = searchText;
        //}

        //void Handle_TextChanged(object? sender, TextChangedEventArgs args)
        //{
        //    var viewModel = BindingContext as MainPage;
        //    viewModel.LabelTextPress = args.NewTextValue;
        //}
        //+
        //string _labelTextPress;
        //public string LabelTextPress
        //{
        //    get
        //    {
        //        return "You entered after press: " + _labelTextPress;
        //    }
        //    set
        //    {
        //        if (_labelTextPress != value)
        //        {
        //            _labelTextPress = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    //count++;

        //    //if (count == 1)
        //    //    CounterBtn.Text = $"Clicked {count} time";
        //    //else
        //    //    CounterBtn.Text = $"Clicked {count} times";

        //    //SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

}
