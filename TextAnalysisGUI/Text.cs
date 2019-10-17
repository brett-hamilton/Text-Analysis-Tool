///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         Text.cs
//	Description:       Uses text from a text file and parses it into tokens for use by other classes
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, September 21, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Utils.Utility;

namespace TextAnalysis
{
	/// <summary>
	/// Gets text from a file and turns it into a list of string tokens for use in other classes
	/// </summary>
	public class Text
	{
		#region Properties
		public string OriginalText { get; private set; }
		public List<string> Tokens { get; private set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Text ( )
		{
			OriginalText = String.Empty;
			Tokens = null;
		} // end Text

		/// <summary>
		/// Parameterized constructor - gets the original text and tokenizes it
		/// </summary>
		/// <param name="path">String path to the text file</param>
		public Text (string path)
		{
			this.OriginalText = ReadFile (path);
			this.Tokens = Tokenize (OriginalText, " \n\t\r.,!;:");
		} // end Text
		#endregion

		#region ReadFile
		/// <summary>
		/// Gets the original text from the file
		/// </summary>
		/// <param name="path">String path to the text file</param>
		/// <returns></returns>
		private string ReadFile (string path)
		{
			StreamReader reader = null;
			string original = string.Empty;

			try
			{
				reader = new StreamReader (path);

				// Store entire text
				original = reader.ReadToEnd ( );
			}
			finally
			{
				if (reader != null)
					reader.Close ( );
			}

			return original;
		} // end ReadFile
		#endregion

		#region Display Methods and ToString
		/// <summary>
		/// Gets the original text from the text file for possible display in another class
		/// </summary>
		/// <returns>String of the original text</returns>
		public string DisplayOriginal ( )
		{
			return "Orginal Text:\n\n" + FormatText (OriginalText);
		} // end DisplayOriginal

		/// <summary>
		/// Formats the string list of tokens for possible display in another class
		/// </summary>
		/// <returns>A string representation of the token list</returns>
		public string DisplayTokens ( )
		{
			int count = 1;			// Counter representing the numbering of tokens
			string list = string.Empty;

			foreach (string token in Tokens)
			{
				// Put together string of numbered tokens
				if (token == "\n")
					list += $"{count}.".PadLeft (4) + @" '\n'" + "\n";
				else
					list += $"{count}.".PadLeft (4) + $" '{token}'\n";

				count++;
			}

			return list;
		} // end DisplayOriginal

		/// <summary>
		/// Uses DisplayOriginal method to get the original text from the text file for possible 
		///		display in another class
		/// </summary>
		/// <returns>String of the original text</returns>
		public override string ToString ( )
		{
			return this.DisplayOriginal ( );
		} // end ToString
		#endregion

		#region GetHashCode
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this text
		/// </summary>
		/// <returns>A hash code for the string representation of this text</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end Text
}