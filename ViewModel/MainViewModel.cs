using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

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
        // The add function is not working right now, it is not adding newly created notepages to the MainPage
        // Fix this later
        // using this video https://youtu.be/5Qga2pniN78
        void Add()
        {
            int count = 0;
            if (string.IsNullOrWhiteSpace(Text))
            {
                count++;
                Items.Add($"New note({count})");
            }
   
            Items.Add(Text);
            //adds the item to the MainPage's viewmodel
            Text = string.Empty;
        }

        [ICommand]
        void Delete(string s)
        {
            if (Items.Contains(s)) 
            {
                Items.Remove(s);
            }
            //removes the item from the MainPage's viewmodel
        }

    }
}
