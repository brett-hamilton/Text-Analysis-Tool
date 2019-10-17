///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         Paragraph.cs
//	Description:       Represents a single paragraph extracted from a text file and calculates statistics
//							about that paragraph
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, September 21, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Utils.Utility;

namespace TextAnalysis
{
	/// <summary>
	/// Represents a single paragraph of text from a text object, calculating information and formatting
	///		for possible display by other classes
	/// </summary>
	public class Paragraph
	{
		private string paragraph = string.Empty;        // The string representation of this sentence

		#region Properties
		public int NumSentences { get; private set; }
		public int WordCount { get; private set; }
		public double AvgSentenceLength { get; private set; }
		/// <summary>
		/// Starting index to look for paragraph
		/// </summary>
		/// <value>The starting index</value>
		public int Start { get; private set; }
		/// <summary>
		/// Ending index of the paragraph
		/// </summary>
		/// <value>The ending index</value>
		public int End { get; private set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Paragraph ( )
		{
			NumSentences = 0;
			WordCount = 0;
			AvgSentenceLength = 0;
			Start = 0;
			End = 0;
		} // end Paragraph

		/// <summary>
		/// Parameterized Constructor - creates a string paragraph based on a list of string
		///		tokens and calculates word count and number of sentences
		/// </summary>
		/// <param name="text">Text object that paragraphs will be extracted from</param>
		/// <param name="start">Starting index for paragraph extraction</param>
		public Paragraph (Text text, int start)
		{
			this.Start = start;
			this.End = 0;
			this.WordCount = 0;
			this.NumSentences = 0;

			int newLineCounter = 0;     // Counts the number of newline characters in a row

			// Construct the paragraph until the end is detected
			for (int i = start; i < text.Tokens.Count; i++)
			{			
				// If the token is not a newline character
				if (text.Tokens[i].IndexOfAny ("\r\n".ToCharArray ( )) < 0)
				{
					if (newLineCounter > 0)
						newLineCounter = 0;

					if (text.Tokens[i].IndexOfAny (",;:".ToCharArray ( )) >= 0)
						paragraph += text.Tokens[i];
					else if (text.Tokens[i].IndexOfAny (".!?".ToCharArray ( )) >= 0)
					{
						NumSentences++;
						paragraph += text.Tokens[i];
					}
					else
					{
						WordCount++;

						if (i != start)
							paragraph += " " + text.Tokens[i];
						else
							paragraph += text.Tokens[i];
					}
				}
				else
				{
					newLineCounter++;

					if (newLineCounter == 2)
					{
						this.End = i;
						break;
					}
				}
			}

			if (this.End == 0)
				this.End = text.Tokens.Count;

			// Calculate average words per sentence
			AvgSentenceLength = WordCount / (NumSentences * 1.0);
		} // end Paragraph
		#endregion

		#region ToString
		/// <summary>
		/// Formats this paragraph for possible display in another class
		/// </summary>
		/// <returns>A formatted string of this paragraph and paragraph statistics</returns>
		public override string ToString ( )
		{
			string formattedSentence = string.Empty;

			// Format this paragraph for proper display
			formattedSentence += FormatText (paragraph, rightMargin: 75) + "\n";

			return formattedSentence;
		} // end ToString
		#endregion

		#region GetHashCode
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this paragraph
		/// </summary>
		/// <returns>A hash code for the string representation of this paragraph</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end Paragraph
}