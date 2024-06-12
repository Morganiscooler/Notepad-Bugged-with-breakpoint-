using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Notepad__easy_.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        // The ID system is not fully developed yet...
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();

            UserItems = new ObservableCollection<Item>
            {
                new Item {Itemid = "1"},
                new Item {Itemid = "2"},
                new Item {Itemid = "3"},
            };
        }


        //public List<String> SelectedItems { get; }
        // The class may not be working, I don't quite understand this part
        // 
        public class Item 
        {
            public string Itemid { get; set; }
        }

        Item selectedItem;
        public Item SelectedItem 
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged("SelectedItem");

                    if (SelectedItem != null) 
                    {
                        // Perform the navigation to the selected item's page
                        PerformNavigation(SelectedItem.Itemid);
                    }
                }
            }
        }

        private ObservableCollection<Item> userItems;
        public ObservableCollection<Item> UserItems 
        {
            get 
            {
                return userItems;
            }
            set
            { 
                userItems = value;
                OnPropertyChanged("UserItems");
                    
            }
        }
        private async void PerformNavigation(string id)
        {
            // just test out with the first 3 id pages
            // the pages may be deleted if the test for grabbing IDs does not work
            if (id == "1")
            {
                await Shell.Current.GoToAsync($"///ViewNote");
            }
            else if (id == "2")
            {
                await Shell.Current.GoToAsync($"///ViewNote2");
            }
            else 
            {
                await Shell.Current.GoToAsync($"///ViewNote3");
            }
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [ICommand]
        private async void Add()
        {
            //put this outside the func later

            int count = 0;
            if (string.IsNullOrWhiteSpace(Text))
            {
                // Fix the issue of the count repeatedly being 1 instead of going up
                count++;
                Text = $"New note({count})";
                Items.Add(Text);
            }
            else
            {
                Items.Add(Text);
            }
            // Add a function here that removes the "Let's get started!" button after the first new note has been added
            Text = string.Empty;


            await Shell.Current.GoToAsync($"///MainPage");
        }

        [ICommand]
        private async void Delete(string s)
        {
            // Fix the delete command not working
            if (Items.Contains(s))
            {
                Console.WriteLine($"{s} has been deleted!");
                Items.Remove(s);
            }
            //removes the item from the MainPage's viewmodel
        }




        [ICommand]
        private async void ColorChanged() 
        {
            List<string> colors = new List<string> { "#ffe66e", "#a1ef9b", "#ffafdf", "#d7afff", "#9edfff" };
            // I want to a command where when the user selects a specific color from the list on the creation screen,
            // the chosen color will be the background of the NotePage along with being the background of the preview
            // of the SwipeView on the mainpage
            foreach (string color in colors) 
            {
                //if (colors[].Select)
            }
            
        }
        //[ICommand]
        //void CreateColor()
        //{
        //    var random = new Random();
        //    var r = Convert.ToByte(random.Next(0, 255));
        //    var g = Convert.ToByte(random.Next(0, 255));
        //    var b = Convert.ToByte(random.Next(0, 255));

        //    return new Color(r, g, b);
        //}

        // Navigation pages
        //=======================================================================================>

        [ICommand]
        private async void ToCreationPage()
        {
            await Shell.Current.GoToAsync($"///CreateNewNote");

        }

        [ICommand]
        private async void ToNotePage()
        {
            // Also fix the issue of the buttons in the collectionview not leading to the saved note page
            await Shell.Current.GoToAsync($"///ViewNote");

        }

        // Setting color for NotePages
        //=======================================================================================>
        public Command ChangeColorYellow
        {
            get
            {
                return new Command(() => {

                    //Change here button background colors
                    BackgroundColor = Color.FromHex("ffe66e"); //or something
                });
            }
        }

        public Command ChangeColorGreen
        {
            get
            {
                return new Command(() => {

                    //Change here button background colors
                    BackgroundColor = Color.FromHex("a1ef9b"); //or something
                });
            }
        }

        public Command ChangeColorPink
        {
            get
            {
                return new Command(() => {

                    //Change here button background colors
                    BackgroundColor = Color.FromHex("ffafdf"); //or something
                });
            }
        }

        public Command ChangeColorPurple
        {
            get
            {
                return new Command(() => {

                    //Change here button background colors
                    BackgroundColor = Color.FromHex("d7afff"); //or something
                });
            }
        }

        public Command ChangeColorBlue
        {
            get
            {
                return new Command(() => {

                    //Change here button background colors
                    BackgroundColor = Color.FromHex("9edfff"); //or something
                });
            }
        }

        public Command ChangeColorLightGray
        {
            get
            {
                return new Command(() => {

                    //Change here button background colors
                    BackgroundColor = Colors.LightGray; //or something
                });
            }
        }

        private Color _backgroundColor = Colors.White;
        public Color BackgroundColor
            {
                get { return _backgroundColor; }
                set
                {
                    if (value == _backgroundColor)
                        return;

                    _backgroundColor = value;
                }
            }



    }
}
