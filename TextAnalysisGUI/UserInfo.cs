///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         UserInfo.cs
//	Description:       Displays a windows form to get user information and validate the input
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
using Utils;

namespace TextAnalysis
{
	/// <summary>
	/// Displays a user interface to gather user information and validate it
	/// </summary>
	public partial class UserInfo : Form
	{
		#region Properties
		public Name UserName { get; private set; }
		public User User { get; private set; } 
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor that initializes window
		/// </summary>
		public UserInfo ( )
		{
			InitializeComponent ( );
		} // end UserInfo
		#endregion

		#region Button Methods
		/// <summary>
		/// Creates a user using the input from the text boxes and validates information
		/// </summary>
		/// <param name="sender">The OK button that generates the event</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void OkButton_Click (object sender, EventArgs e)
		{
			// Create user name and user
			string fName = fNameTextBox.Text;
			string lName = lNameTextBox.Text;
			UserName = new Name (fName, lName);
			User = new User (UserName);

			// Validate email and phone
			string email = emailTextBox.Text;
			string phone = phoneTextBox.Text;

			if (!User.ValidateEmail (email))
			{
				MessageBox.Show (this, "Invalid email. Please input a valid email address.",
					"Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!User.ValidatePhone (phone))
			{
				MessageBox.Show (this, "Invalid phone number. Please input a phone number in the " +
					"format (###) ###-####", "Invalid Phone Number", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			this.Close ( );

		} // end OkButton_Click

		/// <summary>
		/// Closes the user information form
		/// </summary>
		/// <param name="sender">The Cancel button that generates the event</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void CancelButton_Click (object sender, EventArgs e)
		{
			this.Close ( );
		} // end CancelButton_Click
		#endregion

		#region Text Box Methods
		/// <summary>
		/// Selects text in first name text box
		/// </summary>
		/// <param name="sender">The first name text box</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void FNameTextBox_Enter (object sender, EventArgs e)
		{
			fNameTextBox.SelectAll ( );
		} // end FNameTextBox_Enter

		/// <summary>
		/// Selects text in last name text box
		/// </summary>
		/// <param name="sender">The last name text box</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void LNameTextBox_Enter (object sender, EventArgs e)
		{
			lNameTextBox.SelectAll ( );
		} // end LNameTextBox_Enter

		/// <summary>
		/// Selects text in email text box
		/// </summary>
		/// <param name="sender">The email text box</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void EmailTextBox_Enter (object sender, EventArgs e)
		{
			emailTextBox.SelectAll ( );
		} // end EmailTextBox_Enter

		/// <summary>
		/// Selects text in phone text box
		/// </summary>
		/// <param name="sender">The phone text box</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void PhoneTextBox_Enter (object sender, EventArgs e)
		{
			phoneTextBox.SelectAll ( );
		} // end PhoneTextBox_Enter

		/// <summary>
		/// Selects text in the text box
		/// </summary>
		/// <param name="sender">The text box</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void TextBox_Click (object sender, EventArgs e)
		{
			((TextBox) sender).SelectAll ( );
		} // end FNameTextBox_Click
		#endregion
	} // end UserInfo
}