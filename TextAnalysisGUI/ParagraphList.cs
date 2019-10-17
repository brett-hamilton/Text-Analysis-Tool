///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         ParagraphList.cs
//	Description:       A container for a list of paragraphs and statistics about them for display in
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
	public class ParagraphList
	{
		#region Properties
		public List<Paragraph> Paragraphs { get; private set; }
		public int NumParagraphs { get; private set; }
		public double AvgWords { get; private set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public ParagraphList ( )
		{
			Paragraphs = null;
			NumParagraphs = 0;
			AvgWords = 0;
		} // end ParagraphList

		/// <summary>
		/// Parameterized Constructor - Fills paragraph list with paragraphs from text object
		/// </summary>
		/// <param name="text">Text object that will be used to extract paragraphs</param>
		public ParagraphList (Text text)
		{
			Paragraphs = new List<Paragraph> ( );
			NumParagraphs = 0;

			int start = 0;      // Starting index to search for paragraph
			int numWords = 0;   // Accumulator for the number of words

			// Fill sentence list with sentences
			while (start < text.Tokens.Count)
			{
				// Add paragraph to paragraph list starting at specified index
				Paragraphs.Add (new Paragraph (text, start));
				NumParagraphs++;

				// Add number of words in paragraph to accumulator
				numWords += Paragraphs[Paragraphs.Count - 1].WordCount;

				// New starting index based on this paragraphs's ending index
				start = Paragraphs[Paragraphs.Count - 1].End + 1;
			}

			// Calculate average length of sentences
			AvgWords = numWords / (NumParagraphs * 1.0);
		} // end ParagraphList
		#endregion

		#region DisplayParagraphs and ToString
		/// <summary>
		/// Formats the list of paragraphs for possible display in other classes
		/// </summary>
		/// <returns>String representations of paragraphs and statistics about them</returns>
		public string DisplayParagraphs ( )
		{
			string formattedOutput = string.Empty;
			int index = 1;		// Index used for numbering paragraphs

			foreach (Paragraph paragraph in Paragraphs)
			{
				formattedOutput += $"\nParagraph {index}.\n\n";
				formattedOutput += paragraph;
				index++;
			}
			formattedOutput += $"\n\nThere are {NumParagraphs} paragraphs. The average number of " +
				$"words in the paragraphs is {AvgWords:0.#}.";

			return formattedOutput;
		} // end DisplayParagraphs

		/// <summary>
		/// Uses DisplayParagraphs method to ormats the list of paragraphs for possible display in 
		///		other classes
		/// </summary>
		/// <returns>String representations of paragraphs and statistics about them</returns>
		public override string ToString ( )
		{
			return this.DisplayParagraphs ( );
		} // end ToString
		#endregion

		#region GetHashCode		
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this list of
		///		paragraphs
		/// </summary>
		/// <returns>A hash code for the string representation of this paragraph list</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end ParagraphList
}