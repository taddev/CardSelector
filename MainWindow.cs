using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void FileQuit_Activated (object sender, System.EventArgs e)
	{
		//throw new System.NotImplementedException ();
		Application.Quit ();
	}
}
