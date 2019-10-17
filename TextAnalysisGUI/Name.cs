///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         Name.cs
//	Description:       Provides methods for creating, storing, and manipulating a person's name
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Monday, September 17, 2019
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
	/// Used for creating name objects that represent a person's name and provide related methods
	/// </summary>
	/// <seealso cref="System.IEquatable{Utils.Name}" />
	/// <seealso cref="System.IComparable{Utils.Name}" />
	public class Name : IEquatable<Name>, IComparable<Name>
	{
		#region Properties
		public string First { get; set; }
		public string Last { get; set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Name ( )
		{
			First = String.Empty;
			Last = String.Empty;
		} // end Name

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		/// <param name="first">The firstname to be assigned</param>
		/// <param name="last">The lastname to be assigned</param>
		public Name (string first, string last)
		{
			this.First = first;
			this.Last = last;
		} // end Name
		#endregion

		#region ToString
		/// <summary>
		/// Override of Object class ToString method - produces string representation of a name
		/// </summary>
		/// <returns>A formatted string of a name</returns>
		public override string ToString ( )
		{
			return First + " " + Last;
		} // end ToString
		#endregion

		#region IEquatable<Name> Members		
		/// <summary>
		/// Checks if both last and first names of this User are the same as another User
		/// </summary>
		/// <param name="other">The User that is beging compared to this User</param>
		/// <returns>True if names are equal, false otherwise</returns>
		public bool Equals (Name other)
		{
			// If last names are not equal, do not check first name; otherwise, check both names;
			//		only returns true if both names are equal
			if (!this.Last.Equals (other.Last))
				return false;
			else if (!this.First.Equals (other.First))
				return false;
			else
				return true;
		} // end Equals

		/// <summary>
		/// Overrides the Object class Equals method
		/// </summary>
		/// <param name="obj">The object that is being compured to this Name</param>
		/// <returns>True if names are equal, false otherwise</returns>
		/// <exception cref="ArgumentException">The object cannot be compared to a Name</exception>
		public override bool Equals (object obj)
		{
			// Make sure object is not null or wrong object type
			if (obj == null)
				return base.Equals (obj);
			else if (!(obj is Name))
				throw new ArgumentException ($"Cannot compare a Name and an object of type {obj.GetType ( )}.");
			else
				return Equals ((Name) obj);

		} // end Equals
		#endregion

		#region IComparable<Name> Members		
		/// <summary>
		/// Compares two names for ordering by comparing the last name first, then the first name if necessary
		/// </summary>
		/// <param name="other">The name that is being compared to this one</param>
		/// <returns>0 if names are equal, positive number if this name is greater, or negative number if
		///		this name is smaller
		/// </returns>
		public int CompareTo (Name other)
		{
			// First checks if last names are equal; if so, compare first names
			if (!this.Last.Equals (other.Last))
				return this.Last.CompareTo (other.Last);

			return (this.First.CompareTo (other.First));
		} // end CompareTo
		#endregion

		#region GetHashCode		
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this name
		/// </summary>
		/// <returns>A hash code for the string representation of this name</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end Name
}
