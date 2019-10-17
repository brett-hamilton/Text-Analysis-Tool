///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         Sentence.cs
//	Description:       Represents a single sentence from a text object and holds statistics about it
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
	/// A class representing a single sentence from a text object and information related to it
	/// </summary>
	public class Sentence
	{
		private string sentence = string.Empty;      // The string representation of this sentence

		#region Properties
		public int WordCount { get; private set; }
		public double AvgWordLength { get; private set; }
		/// <summary>
		/// The starting index to begin extracting sentence
		/// </summary>
		/// <value>The starting index</value>
		public int Start { get; private set; }
		/// <summary>
		/// The ending index for the end of the sentence
		/// </summary>
		/// <value>The ending index</value>
		public int End { get; private set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Sentence ( )
		{
			WordCount = 0;
			AvgWordLength = 0;
			Start = 0;
			End = 0;
		} // end Sentence

		/// <summary>
		/// Parameterized constructor - uses token list from text object to build the sentence
		///		until the end of the sentence is found
		/// </summary>
		/// <param name="text">The text object to extract the sentence from</param>
		/// <param name="start">Starting index for sentence</param>
		public Sentence (Text text, int start)
		{
			this.Start = start;
			this.WordCount = 0;

			int numChars = 0;		// Accumulator for the number of letters in words

			// Build the sentence until end of sentence is detected
			for (int i = start; i < text.Tokens.Count; i++)
			{
				// If this token is not a punction mark
				if (text.Tokens[i].IndexOfAny (".!?".ToCharArray ( )) < 0)
				{
					// Skip token it is a whitespace character
					if (text.Tokens[i].Contains ("\r") || text.Tokens[i].Contains ("\n"))
						continue;
					// If this token is a "word"
					else if (text.Tokens[i].IndexOfAny (",;:".ToCharArray ( )) < 0)
					{
						// Add to character length
						numChars += text.Tokens[i].Length;

						// If word is not the starting word, add a space before it
						if (i != start)
							sentence += " " + text.Tokens[i];
						// If the word is the first word in sentence, do not add a leading space
						else
							sentence += text.Tokens[i];

						WordCount++;
					}
					// If this token is not a word, do not add leading space
					else
						sentence += text.Tokens[i];
				}
				// If this token is a punction mark
				else
				{
					this.End = i;
					sentence += text.Tokens[i];
					break;
				}
			}

			// Get average length of words
			AvgWordLength = numChars / (WordCount * 1.0);

		} // end Sentence
		#endregion

		#region ToString
		/// <summary>
		/// Formats this sentence for possible display in another class
		/// </summary>
		/// <returns>A formatted string of this sentence and sentence statistics</returns>
		public override string ToString ( )
		{
			string formattedSentence = string.Empty;

			// Formats the string sentence for proper display
			formattedSentence += FormatText (sentence, rightMargin: 75) + "\n";

			return formattedSentence;
		} // end ToString
		#endregion

		#region GetHashCode		
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this sentence
		/// </summary>
		/// <returns>A hash code for the string representation of this sentence</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end Sentence
}