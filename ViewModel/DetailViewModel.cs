using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Notepad__easy_.ViewModel;

[QueryProperty(nameof(Text),nameof(Text))]
[QueryProperty(nameof(Note), nameof(Note))]
[QueryProperty(nameof(Changecolor), nameof(Changecolor))]
[QueryProperty(nameof(Fontsize), nameof(Fontsize))]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [ObservableProperty]
    string note;

    [ObservableProperty]
    double fontsize;

    [ObservableProperty]
    Color changecolor;

    [ICommand]
    async Task Goback() 
    {
        await Shell.Current.GoToAsync("..");
    }

}
