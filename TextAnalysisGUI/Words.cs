///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         Words.cs
//	Description:       Represents a collection of distinct words based on a text object
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
	/// A container class for a list of distinct words
	/// </summary>
	public class Words
	{
		#region Properties
		public List<DistinctWord> WordList { get; private set; }
		/// <summary>
		/// The number of words is the list
		/// </summary>
		/// <value>The number of words</value>
		public int Count { get; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Words ( )
		{
			WordList = null;
			Count = 0;
		} // end Words

		/// <summary>
		/// Parameterized contructor that gets only words out of text object
		/// </summary>
		/// <param name="text">The text from which the words come from</param>
		public Words (Text text)
		{
			WordList = new List<DistinctWord> ( );
			
			// Throw out any non-word or number characters
			char[] delims = " .,;:{}\n\t\r\\<>@!$#%^&*()_=+?[]|0123456789".ToCharArray ( );

			// Start counter at zero
			Count = 0;

			// Fill word list
			for (int i = 0; i < text.Tokens.Count; i++)
			{
				if (text.Tokens[i].IndexOfAny (delims) < 0)
				{
					DistinctWord newWord = new DistinctWord (text.Tokens[i]);

					// Check if word already exists
					if (WordList.Contains (newWord))
					{
						int index = WordList.IndexOf (newWord);
						WordList[index].Counter++;
					}
					// If word is new, add it to list
					else
					{
						WordList.Add (newWord);

						// Only increase count when new word is added
						Count++;
					}
				}
			}

			// Sort words alphabetically, if words exist in list
			if (Count > 0)
			{
				WordList.Sort ( );
			}

		} // end Words
		#endregion

		#region DisplayWords and ToString
		/// <summary>
		/// Formats the list of words for display in another class
		/// </summary>
		/// <returns>The formatted string of words and their counts</returns>
		public string DisplayWords ( )
		{
			string formattedWords = string.Empty;
			int number = 1;			// Counter to number the list

			foreach (DistinctWord word in WordList)
			{
				formattedWords += $"{number}. ".PadLeft (5) + word + "\n";
				number++;
			}

			return formattedWords;
		} // end DisplayWords

		/// <summary>
		/// Uses DisplayWords method to format the list of words for display in another class
		/// </summary>
		/// <returns>The formatted string of words and their counts</returns>
		public override string ToString ( )
		{
			return DisplayWords ( );
		} // end ToString
		#endregion

		#region GetHashCode
		/// <summary>
		/// Override of Object class method - generates hash code for this list of words
		/// </summary>
		/// <returns>A hash code for the string representation of this word list</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end Words
}