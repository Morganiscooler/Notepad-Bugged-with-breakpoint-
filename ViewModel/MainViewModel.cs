using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

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
        string id;

        [ObservableProperty]
        string note;

        [ObservableProperty]
        double fontsize;

        [ObservableProperty]
        Color changecolor;


        [ICommand]
        async Task Add()
        {
            //put this outside the func later

            int count = 0;
            if (string.IsNullOrWhiteSpace(Text))
            {
                // Fix the issue of the count repeatedly being 1 instead of going up
                count++;
                Text = $"New note({count})";
                Items.Add(Id);
                //Items.Add(item: "a");
            }
            else
            {
                Items.Add(Id);
            }
            // Add a function here that removes the "Let's get started!" button after the first new note has been added
            // Allow each newly created note to have a new name instead of the same name
            Text = string.Empty;

            await Shell.Current.GoToAsync($"../../");
        }
  

        [ICommand]
        void Clear()
        {
            Items.Clear();
        }

        [ICommand]
        void Delete(string s)
        {
            //string s = Text;
            // Problem: Item does not contain s, find what else it contains so it can remove it.
            // items will never contain Text, because it gets reset to string.Empty at the end.

            // Find a way to remove anything that contains ANY string and not just a specific set of strings
            if (!Items.Contains(item: Id))
            {
                Items.Add(item: Id);
            }
            else
            {
                Items.Remove(item: Id);
            }

            //removes the item from the MainPage's viewmodel
        }

        [ICommand]
        void ColorYellow()
        {
            // Find a way to pass over the hex color to NewNotePage
            Changecolor = Color.FromHex("#ffe66e");
            //BackgroundColor = Changecolor;
        }

        // Navigation pages
        //=======================================================================================>
        [ICommand]
        async Task Tap(string s) 
        {
            string n = Note;
            // the observableproperty Changecolor is NULL fix this ASAP or else the color won't bind to ANY PAGE!!
            //Changecolor = BackgroundColor;

            //Color color = Changecolor;
            // Need to modify NotePage so it saves a different text for each individual newly created note

            // Changecolor is not working ?
             // Change this to be flexible to the 6 different colors + choose from file
            Color color = Changecolor;
            await Shell.Current.GoToAsync($"{nameof(NewNotePage)}?Text={s}&Note={n}&Color={color}&TextSize={Fontsize}");
        }


        [ICommand]
        Task ToCreationPage() => Shell.Current.GoToAsync(nameof(Create_NewNote));

        

        [ICommand]
        Task ToNotePage() => Shell.Current.GoToAsync(nameof(NotePage));

        // Also fix the issue of the buttons in the collectionview not leading to the saved note page




        // Setting color for NotePages
        //=======================================================================================> 
        [ICommand]
        public async Task<FileResult> PickAndShow(PickOptions options)
        {
            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                 
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                    {
                        using var stream = await result.OpenReadAsync();
                        var image = ImageSource.FromStream(() => stream);
                    }
                }

                // Returns the correct result, now just need to set it as the NotePage & NewNotePage's background
                return result;
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }

            return null;
        }
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
                    Changecolor = Color.FromHex("a1ef9b"); // This works when inside this command, however I am unsure how to pass it through the QueryProperty.
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
