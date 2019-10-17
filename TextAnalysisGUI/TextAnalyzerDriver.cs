///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         TextAnalyzerDriver.cs
//	Description:       Runs the text analysis program, handling the windows forms that display
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Monday, September 30, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalysis
{
	/// <summary>
	/// Runs the text analysis program
	/// </summary>
	public static class TextAnalyzerDriver
	{
		#region Main
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main ( )
		{
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new SplashScreenForm ( ));
			Application.Run (new TextAnalyzerForm ( ));
		} // end Main 
		#endregion
	} // TextAnalyzerDriver
}
