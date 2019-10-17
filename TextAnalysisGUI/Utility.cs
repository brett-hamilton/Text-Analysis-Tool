///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         Utility.cs
//	Description:       Static class to provide common methods for use in other classes
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Monday, September 16, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
	/// <summary>
	/// Provide common, useful static methods to be used in other classes where appropriate
	/// </summary>
	public static class Utility
	{
		#region Tokenize
		/// <summary>
		/// Converts a string to a list of tokens based on specified delimiters
		/// </summary>
		/// <param name="original">The string to be tokenized</param>
		/// <param name="delimiters">The set of delimiters used to tokenize the string</param>
		/// <returns>A list of strings representing the tokens</returns>
		public static List<string> Tokenize (string original, string delimiters)
		{
			List<string> tokens = new List<string> ( );
			string text = Clean (original);
			string token = string.Empty;			// Holds token from text to put in list

			while (!string.IsNullOrEmpty (text))
			{
				int col = text.IndexOfAny (delimiters.ToCharArray ( ));     // Search for delimiter

				if (col == 0)
				{
					// Set column to first if delimter is found at first position
					col = 1;
				}

				if (col < 0)
				{
					// If delimiter not found, the rest of text is a token
					col = text.Length;
				}

				token = text.Substring (0, col);
				tokens.Add (token);

				if (col < text.Length)
				{
					// If there is more text to read, cut off the token just added
					text = text.Substring (col);
				}
				else
				{
					// No text left to read
					text = string.Empty;
				}

				// Ignore spaces and tab characters
				text = text.Trim (" \t".ToCharArray ( ));

			}

			return tokens;
		} // end Tokenize
		#endregion

		#region Clean
		/// <summary>
		/// Trims off any leading or trailing spaces or tabs from string and replaces the
		///		\r\n sequence with a single newline character
		/// </summary>
		/// <param name="text">The string that needs to be trimmed</param>
		/// <returns>The original string without leading or trailing spaces or tabs</returns>
		private static string Clean (string txt)
		{
			string cleanedTxt = txt.Trim (" \t\n\r".ToCharArray ( ));
			cleanedTxt = cleanedTxt.Replace ("\r\n", "\n");

			return cleanedTxt;
		} // end Clean
		#endregion

		#region Welcome and Goodbye Messages
		/// <summary>
		/// Formats a welcoming message for display in another class
		/// </summary>
		/// <param name="msg">The message to be shown</param>
		/// <param name="author">The author of the program</param>
		/// <param name="subtitle">Text beneath the title, default is course name</param>
		public static string WelcomeMessage (string msg, string author = "Brett Hamilton", 
			string subtitle = "Computer Science - 2210")
		{
			return "Welcome to my program!\n" + subtitle + "\nAuthor: " + author +
				"\n\n" + msg;
		} // end WelcomeMessage

		/// <summary>
		/// Formats a goodbye message for display
		/// </summary>
		/// <param name="msg">The body of the message</param>
		/// <returns></returns>
		public static string GoodbyeMessage (string msg)
		{
			return "Thank you for using this program!\n\n" + msg + "\nGoodbye!";
		} // end GoodbyeMsssage
		#endregion

		#region FormatText
		/// <summary>
		/// Formats string text into a specified line length
		/// </summary>
		/// <param name="txt">String text to be formatted</param>
		/// <param name="leftMargin">Desired left margin for the text</param>
		/// <param name="rightMargin">Desired left margin for the text</param>
		/// <returns></returns>
		public static string FormatText (string txt, int leftMargin = 0, int rightMargin = 80)
		{
			string cleanedTxt = Clean (txt);

			// Break down text into list of tokens
			List<string> tokens = Tokenize (cleanedTxt, " .,!?:;\n\t\r");

			int maxLine = rightMargin - leftMargin;		// Max line length
			string formattedOutput = string.Empty;      // Formatted string to be returned
			int lineLength = 0;							// Tracks current line length

			for (int i = 0; i < tokens.Count; i++)
			{
				// Check to see if there is enough line space to add token
				if (lineLength + tokens[i].Length > maxLine)
				{
					formattedOutput = formattedOutput.Insert (formattedOutput.Length, "\n");
					lineLength = 0;
				}

				// Ignore single newline characters, keep new paragraphs
				if (tokens[i] == "\n")
				{
					if (i + 1 < tokens.Count)
					{
						if (tokens[i+1] == "\n")
						{
							formattedOutput = formattedOutput.Insert (formattedOutput.Length, "\n\n");
							lineLength = 0;
						}
					}

					continue;
				}

				// Check if it is a puncuation or the start of a line
				if (tokens[i].IndexOfAny (".!?,;:".ToCharArray ( )) >= 0 || lineLength == 0)
				{
					formattedOutput += tokens[i];
					lineLength += tokens[i].Length;
				}
				else
				{
					formattedOutput += " " + tokens[i];
					lineLength += 1 + tokens[i].Length;
				}

			}

			return formattedOutput;
		} // end FormatText
		#endregion

		#region Skip
		/// <summary>
		/// Skips a specified number of lines
		/// </summary>
		/// <param name="n">The number of lines to be skipped</param>
		/// <returns>A string containing the new line characters</returns>
		public static string Skip (int n = 1)
		{
			string lines = string.Empty;

			for (int i = 0; i < n; i++)
			{
				lines += "\n";
			}

			return lines;
		} // end Skip
		#endregion

		#region PressAnyKey
		/// <summary>
		/// Displays press any key message at bottom of console window
		/// </summary>
		/// <param name="msg">Message to be printed</param>
		/// <returns>Formatted string with line skips and message</returns>
		public static string PressAnyKey (string msg = "Press any key to continue...")
		{
			return msg;
		} // end PressAnyKey
		#endregion

	} // end Utility
}
