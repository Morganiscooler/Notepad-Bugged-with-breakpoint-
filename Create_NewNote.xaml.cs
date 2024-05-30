using Microsoft.Maui.Graphics.Converters;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Communication = Microsoft.Maui.ApplicationModel.Communication;

namespace Notepad__easy_;

public partial class Create_NewNote : ContentPage
{
    NotePage notePage = new NotePage();
    MainPage mainPage = new MainPage();

    // Color buttons:
    public Create_NewNote()
	{
		InitializeComponent();
		
    }
    private void FontSize(object sender, EventArgs e) 
    {
        double value = Slider.Value;
        SliderValueTest.FontSize = value;
        SliderValueTest.Text = $"The size of the text is {value}";
        // Create my own fontsize property that accesses the text property of the next page, notePage
        //notePage.FontSize = value;
    }

    // Function for using one of the 6 default colors as the background of the note
    private void Yellow(object sender, EventArgs e)
    {
        // Store the color chosen as the background for the new note once made

        // Visual effects for a single color button being selected on click:
        //Button button = (Button)sender;
        yellow.IsEnabled = true;
        if (yellow.IsEnabled == true) 
        {
            yellow.BorderColor = Colors.Black;
            yellow.BorderWidth = 5;

            //green
            green.BorderColor = Colors.Black;
            green.BorderWidth = 3;
            //pink
            pink.BorderColor = Colors.Black;
            pink.BorderWidth = 3;
            //Purple
            purple.BorderColor = Colors.Black;
            purple.BorderWidth = 3;
            //blue
            blue.BorderColor = Colors.Black;
            blue.BorderWidth = 3;
            //gray
            gray.BorderColor = Colors.Black;
            gray.BorderWidth = 3;
        }
        // All other buttons are disabled:

    }
    private void Green(object sender, EventArgs e)
    {
        // Store the color chosen as the background for the new note once made

        // Visual effects for a single color button being selected on click:
        //Button button = (Button)sender;
        green.IsEnabled = true;
        if (green.IsEnabled == true)
        {
            green.BorderColor = Colors.Black;
            green.BorderWidth = 5;

            //Yellow
            yellow.BorderColor = Colors.Black;
            yellow.BorderWidth = 3;
            //pink
            pink.BorderColor = Colors.Black;
            pink.BorderWidth = 3;
            //Purple
            purple.BorderColor = Colors.Black;
            purple.BorderWidth = 3;
            //blue
            blue.BorderColor = Colors.Black;
            blue.BorderWidth = 3;
            //gray
            gray.BorderColor = Colors.Black;
            gray.BorderWidth =  3;
        }
    }
    private void Pink(object sender, EventArgs e)
    {
        // Store the color chosen as the background for the new note once made

        // Visual effects for a single color button being selected on click:
        pink.IsEnabled = true;
        if (pink.IsEnabled == true)
        {
            pink.BorderColor = Colors.Black;
            pink.BorderWidth = 5;

            //Yellow
            yellow.BorderColor = Colors.Black;
            yellow.BorderWidth = 3;
            //pink
            green.BorderColor = Colors.Black;
            green.BorderWidth = 3;
            //Purple
            purple.BorderColor = Colors.Black;
            purple.BorderWidth = 3;
            //blue
            blue.BorderColor = Colors.Black;
            blue.BorderWidth = 3;
            //gray
            gray.BorderColor = Colors.Black;
            gray.BorderWidth = 3;
        }

    }
    private void Purple(object sender, EventArgs e)
    {
        // Store the color chosen as the background for the new note once made

        // Visual effects for a single color button being selected on click:
        purple.IsEnabled = true;
        if (purple.IsEnabled == true)
        {
            purple.BorderColor = Colors.Black;
            purple.BorderWidth = 5;

            //Yellow
            yellow.BorderColor = Colors.Black;
            yellow.BorderWidth = 3;
            //pink
            pink.BorderColor = Colors.Black;
            pink.BorderWidth = 3;
            //Purple
            green.BorderColor = Colors.Black;
            green.BorderWidth = 3;
            //blue
            blue.BorderColor = Colors.Black;
            blue.BorderWidth = 3;
            //gray
            gray.BorderColor = Colors.Black;
            gray.BorderWidth = 3;
        }

    }
    private void Blue(object sender, EventArgs e)
    {
        // Store the color chosen as the background for the new note once made

        // Visual effects for a single color button being selected on click:
        blue.IsEnabled = true;
        if (blue.IsEnabled == true)
        {
            blue.BorderColor = Colors.Black;
            blue.BorderWidth = 5;

            //Yellow
            yellow.BorderColor = Colors.Black;
            yellow.BorderWidth = 3;
            //pink
            pink.BorderColor = Colors.Black;
            pink.BorderWidth = 3;
            //Purple
            purple.BorderColor = Colors.Black;
            purple.BorderWidth = 3;
            //blue
            green.BorderColor = Colors.Black;
            green.BorderWidth = 3;
            //gray
            gray.BorderColor = Colors.Black;
            gray.BorderWidth = 3;
        }

    }
    private void Gray(object sender, EventArgs e)
    {
        // Store the color chosen as the background for the new note once made

        // Visual effects for a single color button being selected on click:
        gray.IsEnabled = true;
        if (gray.IsEnabled == true)
        {
            gray.BorderColor = Colors.Black;
            gray.BorderWidth = 5;

            //Yellow
            yellow.BorderColor = Colors.Black;
            yellow.BorderWidth = 3;
            //pink
            pink.BorderColor = Colors.Black;
            pink.BorderWidth = 3;
            //Purple
            purple.BorderColor = Colors.Black;
            purple.BorderWidth = 3;
            //blue
            blue.BorderColor = Colors.Black;
            blue.BorderWidth = 3;
            //gray
            green.BorderColor = Colors.Black;
            green.BorderWidth = 3;
        }

    }

    // Function for UPLOADING your own background as the note's background
    private void UploadNoteColor(object sender, EventArgs e)
    {
        // Click event works (Confirmed)
        Upload.IsEnabled = true;
        if (Upload.IsEnabled == true) 
        {
            // Allow user to open file and choose PNG/JPEG from computer
        }    

    }
    private void PressedBtn(object sender, EventArgs e)
    {
        // Click event works (Confirmed)
        Upload.BackgroundColor = Colors.LightGray;

    }
    private void ReleasedBtn(object sender, EventArgs e)
    {
        // Click event works (Confirmed)
        Upload.BackgroundColor = Colors.Gray;

    }

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

            return result;
        }
        catch (Exception ex)
        {
            // The user canceled or something went wrong
        }

        return null;
    }
    private void ContinueBtn_Clicked(object sender, EventArgs e)
    {

    }
    int noteNum = 0;
    int noteCount = 0;
    private void OpenNotePage(object sender, EventArgs e)
    {
        noteNum++;
        NotePage notePage = new NotePage();
        //* Find a way to display text on the mainpage about the amount of new notes created
        MainPage mainPage = new MainPage();
        noteCount++;
        //mainPage.DisplayAlert($"The amount of new notes created is {noteCount}");

        notePage.Title = EnterName.Text;
        

        if (notePage.Title == null) 
        {       
            notePage.Title = $"New note ({noteNum})";
        }

        Navigation.PushAsync(notePage);
        
    }




    // Add a function here that automatically sets the window size's height/width to a number
}