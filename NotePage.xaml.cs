using Notepad__easy_.ViewModel;
using System.Windows.Input;
namespace Notepad__easy_;

public partial class NotePage : ContentPage
{
	public NotePage(MainViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
		// The background color will be whatever the user picked from the previous contentpage
		// in Create_NewNote.cs
        //Notepad.BackgroundColor

    }

}