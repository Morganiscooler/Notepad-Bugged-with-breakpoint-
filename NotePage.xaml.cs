using Notepad__easy_.ViewModel;
using System.Windows.Input;
namespace Notepad__easy_;

public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
		// The background color will be whatever the user picked from the previous contentpage
		// in Create_NewNote.cs
        //Notepad.BackgroundColor

    }

    private void BackHome(object sender, EventArgs e) 
	{
        MainViewModel vm = new MainViewModel();
        MainPage mainPage = new MainPage(vm);
		mainPage.BindingContext = vm;
        Navigation.PushAsync(mainPage);
		// Go back to the MainPage
	}
}