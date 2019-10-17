///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         SentenceList.cs
//	Description:       A container for a list of sentences and statistics about them for display in
//							other classes
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

namespace TextAnalysis
{
	/// <summary>
	/// Container for a list of sentence objects and information about them to be displayed
	/// </summary>
	public class SentenceList
	{
		#region Properties
		public List<Sentence> Sentences { get; private set; }
		public int NumSentences { get; private set; }
		public double AvgWords { get; private set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SentenceList ( )
		{
			Sentences = null;
			NumSentences = 0;
			AvgWords = 0;
		} // end SentenceList

		/// <summary>
		/// Parameterized Constructor - fills list of sentences with sentences and determines
		///		the number of sentences and average number of words
		/// </summary>
		/// <param name="text">Text object that will be used to extract sentences</param>
		public SentenceList (Text text)
		{
			Sentences = new List<Sentence> ( );
			NumSentences = 0;

			int start = 0;			// Starting index to search for sentences
			int numWords = 0;		// Accumulator for the number of words

			// Fill sentence list with sentences
			while (start < text.Tokens.Count)
			{
				// Add sentence to sentence list starting at specified index
				Sentences.Add (new Sentence(text, start));
				NumSentences++;

				// Add number of words in this sentence to accumulator
				numWords += Sentences[Sentences.Count - 1].WordCount;

				// New starting index based on this sentence's ending index
				start = Sentences[Sentences.Count - 1].End + 1;

			}

			// Calculate average length of sentences
			AvgWords = numWords / (NumSentences * 1.0);

		} // end SentenceList
		#endregion

		#region DisplaySentences and ToString
		/// <summary>
		/// Formats the list of sentences for possible display in other classes
		/// </summary>
		/// <returns>String representations of sentences and statistics about them</returns>
		public string DisplaySentences ( )
		{
			string formattedOutput = string.Empty;
			int index = 1;

			foreach (Sentence sentence in Sentences)
			{
				formattedOutput += $"\nSentence {index}.\n\n";
				formattedOutput += sentence;
				index++;
			}

			formattedOutput += $"\n\nThere are {NumSentences} sentences with an average length " +
				$"of {AvgWords:0.#} words.";

			return formattedOutput;
		} // end DisplaySentences

		/// <summary>
		/// Uses the DisplaySentences to format the list of sentences for possible display in other classes
		/// </summary>
		/// <returns>String representations of sentences and statistics about them</returns>
		public override string ToString ( )
		{
			return this.DisplaySentences ( );
		} // end ToString
		#endregion

		#region GetHashCode
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this list of sentences
		/// </summary>
		/// <returns>A hash code for the string representation of this sentence list</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end SentenceList
}