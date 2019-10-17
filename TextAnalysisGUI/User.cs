///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         User.cs
//	Description:       Provides methods for creating, storing, and validating information about a user
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utils
{
	/// <summary>
	/// Provides methods for creating a user object and storing data about that user
	/// </summary>
	/// <seealso cref="System.IEquatable{Utils.User}" />
	/// <seealso cref="System.IComparable{Utils.User}" />
	public class User : IEquatable<User>, IComparable<User>
	{
		#region Properties
		public Name UserName { get; private set; }
		public string Email { get; private set; }
		public string Phone { get; private set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public User ( )
		{
			this.UserName = null;
			this.Email = String.Empty;
			this.Phone = String.Empty;
		} // end User

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		/// <param name="name">The name.</param>
		public User (Name name)
		{
			this.UserName = name;
			this.Email = String.Empty;
			this.Phone = String.Empty;
		} // end User
		#endregion

		#region Validate Email and Phone		
		/// <summary>
		/// Ensures the email address is valid and only sets email if valid
		/// </summary>
		/// <param name="email">Email address to be validated</param>
		/// <returns>True if email is valid, false otherwise</returns>
		public bool ValidateEmail (string email)
		{
			// Pattern for desired email format
			Regex pattern = new Regex (@"([a-z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|" +
				@"(([a-z0-9\-]+\.)+))([a-z]{2,4}|[0-9]{1,3})", RegexOptions.IgnoreCase);

			// Test email for validity
			Match match = pattern.Match (email);
			if (match.Success)
			{
				Email = email;
				return true;
			}
			else
				return false;
		} // end ValidateEmail

		/// <summary>
		/// Ensures the phone number is valid and only sets phone if valid
		/// </summary>
		/// <param name="phone">Phone number to be validated</param>
		/// <returns>True if phone number is valid, false otherwise</returns>
		public bool ValidatePhone (string phone)
		{
			// Pattern for desired phone number format
			Regex pattern = new Regex (@"\([0-9]{3}\)\s[0-9]{3}-[0-9]{4}");

			// Test phone number for validity
			Match match = pattern.Match (phone);
			if (match.Success)
			{
				Phone = phone;
				return true;
			}
			else
				return false;
		} // end ValidatePhone
		#endregion

		#region ToString
		/// <summary>
		/// Formats a user into a readable string
		/// </summary>
		/// <returns>A formatted string representation of a user</returns>
		public override string ToString ( )
		{
			return $"User: {UserName}\nEmail: {Email}\nPhone: {Phone}\n";
		} // end ToString
		#endregion

		#region IEquatable<User> Members				
		/// <summary>
		/// Tests for equality between two users
		/// </summary>
		/// <param name="other">A user that is being compared to this user</param>
		/// <returns>
		/// True if the users' names, emails, and phone numbers are the same; false otherwise
		/// </returns>
		public bool Equals (User other)
		{
			// Tests users' names, emails, and phones sequentially; if any of them are not equal,
			//		stop testing and return false
			if (!this.UserName.Equals (other.UserName))
				return false;
			else if (!this.Email.Equals (other.Email))
				return false;
			else if (!this.Phone.Equals (other.Phone))
				return false;
			else
				return true;
		} // end Equals

		/// <summary>
		/// Overrides the Object class Equals method
		/// </summary>
		/// <param name="obj">The object that is being compared to this user</param>
		/// <returns>
		/// True if the users' names, emails, and phone numbers are the same; false otherwise
		/// </returns>
		public override bool Equals (object obj)
		{
			// Checks if object is null or object is wrong object type
			if (obj == null)
				return base.Equals (obj);
			else if (!(obj is Name))
				throw new ArgumentException ($"Cannot compare a User and an object of type {obj.GetType ( )}.");
			else
				return Equals ((User) obj);
		} // end Equals
		#endregion

		#region IComparable<User> Members		
		/// <summary>
		/// Compares this user to another user by name for ordering
		/// </summary>
		/// <param name="other">The User that will be compared to this this User</param>
		/// <returns>
		/// 0 if users are equal, positive number if this user is greater, or negative number if
		///		this user is smaller
		/// </returns>
		public int CompareTo (User other)
		{
			return this.UserName.CompareTo (other.UserName);
		} // end CompareTo
		#endregion

		#region GetHashCode
		/// <summary>
		/// Override of Object class GetHashCode method - generates a hash code for this user
		/// </summary>
		/// <returns>A hash code for the string representation of this user</returns>
		public override int GetHashCode ( )
		{
			return this.ToString ( ).GetHashCode ( );
		} // end GetHashCode
		#endregion
	} // end User
}
