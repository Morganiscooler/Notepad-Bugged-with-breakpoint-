using Microsoft.Maui.Graphics.Converters;
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
            List<string> colors = new List<string> { "#ffe66e", "#a1ef9b", "#ffafdf", "#d7afff", "#9edfff" };
            var random = new Random();
            // Change the random.Next color choices to the colors in the list eventually...
            var r = Convert.ToByte(random.Next(0, 255));
            var g = Convert.ToByte(random.Next(0, 255));
            var b = Convert.ToByte(random.Next(0, 255));

            return new Color(r, g, b);
        }

        int count = 0;
        // Change the color randomizer to automatically happen when the DOM content loads for the app
        // *Everytime it is reopened
        private void CreateNewNotes(object sender, EventArgs e) 
        {
            // Click button works
            Button btn = new Button();    
            Notes.BackgroundColor = CreateColor();
        }
        int testcount = 0;

        // This function should be renamed to CreateNewNotes;
        // there needs to be a new function that occurs when you open a preexisting note...
        private void OpenNote(object sender, EventArgs e) 
        {
            // Click event works (Confirmed)
            Create_NewNote openNote = new Create_NewNote();
            Navigation.PushAsync(new Create_NewNote());  

        }
        public MainPage()
        {
            InitializeComponent();
            Notes.BackgroundColor = CreateColor();

            //Announce the amount of new notes created here on the Mainpage's grid
            //SemanticScreenReader.Announce(noteCount.Text);

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
