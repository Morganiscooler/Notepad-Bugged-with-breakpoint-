using Notepad__easy_.ViewModel;

namespace Notepad__easy_;

public partial class NewNotePage : ContentPage
{
	public NewNotePage(DetailViewModel vm2)
	{
		InitializeComponent();
		BindingContext = vm2;
	}
}