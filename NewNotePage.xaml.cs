using Notepad__easy_.ViewModel;

namespace Notepad__easy_;

public partial class NewNotePage : ContentPage
{
	public NewNotePage(DetailViewModel vm2)
	{
		InitializeComponent();
		BindingContext = vm2;
	}


	// Add a breakpoint here to check if queryproperty passed over the variables 
	// Changecolor is null and fontsize is 0, fix this so they both pass over the correct values.
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}