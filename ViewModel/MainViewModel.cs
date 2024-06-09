using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace Notepad__easy_.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
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



    }
}
