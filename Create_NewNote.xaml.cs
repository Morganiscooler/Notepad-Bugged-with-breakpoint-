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
	public Create_NewNote()
	{
		InitializeComponent();
		
    }

    // Function for using one of the 6 default colors as the background of the note
    private void SetNoteColor(object sender, EventArgs e)
    {

        // Store the color chosen as the background for the new note once made
        NewPage1 NotePage = new NewPage1();
        


    }

    // Function for UPLOADING your own background as the note's background
    private void UploadNoteColor(object sender, EventArgs e)
    {
        // Click event works (Confirmed)
        
        

    }
}