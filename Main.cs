/**
 * Author: Tad DeVries
 * Email: tad@splunk.net
 * Date: 05/22/2012
 **/

using System;
using Gtk;
using System.Xml;


namespace CardSelector
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
