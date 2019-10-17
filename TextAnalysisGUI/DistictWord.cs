///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         DistinctWord.cs
//	Description:       Represents a single word of text and keeps track of how many times that word appears
//							in text file
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
	/// Creates a distinct, lower case word and counts the number of times it appears in a text object
	/// </summary>
	/// <seealso cref="System.IEquatable{TextAnalysis.DistinctWord}" />
	/// <seealso cref="System.IComparable{TextAnalysis.DistinctWord}" />
	public class DistinctWord : IEquatable<DistinctWord>, IComparable<DistinctWord>
	{
		#region Properties
		public string Word { get; private set; }
		/// <summary>
		/// The number of times this word appears in a text object
		/// </summary>
		/// <value>The counter number</value>
		public int Counter { get; set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public DistinctWord ( )
		{
			Word = string.Empty;
			Counter = 0;
		} // end DistinctWord

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="word">String word used to create a distinct word</param>
		public DistinctWord (string word)
		{
			this.Word = word.ToLower ( );
			Counter = 1;
		} // end DistinctWord
		#endregion

		#region IComparable Members		
		/// <summary>
		/// Compares two distinct words by the string property Word
		/// </summary>
		/// <param name="other">The distinct word being compared to this one</param>
		/// <returns>
		/// 0 if both distinct words are equal; positive number if this distinct word is greater;
		///		negative number if this distinct word is smaller
		/// </returns>
		public int CompareTo (DistinctWord other)
		{
			return this.Word.CompareTo (other.Word);
		} // end CompareTo
		#endregion

		#region IEquatable Members		
		/// <summary>
		/// Tests for equality based on the walue of the string word
		/// </summary>
		/// <param name="other">The distinct word being compared to this</param>
		/// <returns>True if the string words are equal; false otherwise</returns>
		public bool Equals (DistinctWord other)
		{
			return this.Word.Equals (other.Word);
		} // end Equals

		/// <summary>
		/// Overrides the Object class Equals method
		/// </summary>
		/// <param name="obj">The object that is being compared to this distinc word</param>
		/// <returns>True if the string words are equal; false otherwise</returns>
		/// <exception cref="ArgumentException">The object cannot be compared to a distinct word</exception>
		public override bool Equals (object obj)
		{
			// Make sure object is not null and is correct object type
			if (obj == null)
				return base.Equals (obj);
			else if (!(obj is DistinctWord))
			{
				throw new ArgumentException ($"Cannot compare a DistinctWord and an object of " +
					$"type {obj.GetType ( )}.");
			}
			else
				return Equals ((DistinctWord) obj);

		} // end Equals
		#endregion

		#region ToString		
		/// <summary>
		/// Formats the string word and counter variable for display in other classes
		/// </summary>
		/// <returns>A string representations of the word and counter</returns>
		public override string ToString ( )
		{
			return Word + $"{Counter}".PadLeft (30 - Word.Length);
		} // end ToString
		#endregion

		#region GetHashCode		
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this distinct word
		/// </summary>
		/// <returns>A hash code for the string representation of this distinct word</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end DistinctWord
}