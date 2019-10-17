///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         SplashScreenForm.cs
//	Description:	   Displays the splash screen when program is started
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Monday, September 30, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalysis
{
	/// <summary>
	/// Loads the splash screen with program information and graphics
	/// </summary>
	public partial class SplashScreenForm : Form
	{
		#region Constructor and Form Load
		/// <summary>
		/// Default constructor that initializes that splash screen
		/// </summary>
		public SplashScreenForm ( )
		{
			InitializeComponent ( );
		} // end SplashScreenForm

		/// <summary>
		/// Replace version label with current product version
		/// </summary>
		/// <param name="sender">The object sending the event</param>
		/// <param name="e">The event instance that holds event information</param>
		private void SplashScreenForm_Load (object sender, EventArgs e)
		{
			this.splashVersionLabel.Text = $"Version {Application.ProductVersion}";
		} // end SplashScreenForm_Load 
		#endregion

		#region Splash Timer
		/// <summary>
		/// After the tick event, close the splash screen
		/// </summary>
		/// <param name="sender">The object generating the event</param>
		/// <param name="e">The event instance that holds event information</param>
		private void SplashTimer_Tick (object sender, EventArgs e)
		{
			this.Close ( );
		} // end SplashTimer_Tick 
		#endregion
	} // end SplashScreenForm
}
