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

        }


        //public List<String> SelectedItems { get; }
        // The class may not be working, I don't quite understand this part
        // 

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [ObservableProperty]
        string note;

        [ObservableProperty]
        Color changecolor;


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

            await Shell.Current.GoToAsync($"../../");
        }

        [ICommand]
        void Delete(string s)
        {
            // Fix the delete command not working
            if (Items.Contains(s))
            {
                Console.WriteLine($"{s} has been deleted!");
                Items.Remove(s);
            }
            //removes the item from the MainPage's viewmodel
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
        async Task Tap(string s) 
        {
            string n = Note;
            Changecolor = BackgroundColor;
            Color color = Changecolor;
            // Need to modify NotePage so it saves a different text for each individual newly created note
            await Shell.Current.GoToAsync($"{nameof(NewNotePage)}?Text={s}&Note={n}&Color={color}");
        }


        [ICommand]
        Task ToCreationPage() => Shell.Current.GoToAsync(nameof(Create_NewNote));

        

        [ICommand]
        Task ToNotePage() => Shell.Current.GoToAsync(nameof(NotePage));

        // Also fix the issue of the buttons in the collectionview not leading to the saved note page




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

        private Color _backgroundColor = Color.FromHex("ffe66e");
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
