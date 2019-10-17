///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         TextAnalyzerForm.cs
//	Description:	   Displays the main window that handles the text analysis user interface
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Monday, September 30, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;
using static Utils.Utility;

namespace TextAnalysis
{
	/// <summary>
	/// Runs the main user interface that allows users to open a text file and view statistics
	///		about the text
	/// </summary>
	public partial class TextAnalyzerForm : Form
	{
		#region Private Attributes
		private Text text = null;                   // Holds information about the text object
		private Words words = null;                 // Holds information about words
		private SentenceList sentences = null;      // Holds information about sentences
		private ParagraphList paragraphs = null;    // Holds information about paragraphs
		private UserInfo info = null;               // Used to show window to get user info
		private AboutBoxForm about = null;          // Used to show about box
		private string path = string.Empty;         // Holds the path to the text file 
		#endregion

		#region Constructor and Form Load
		/// <summary>
		/// Default constructor that shows the main user interface
		/// </summary>
		public TextAnalyzerForm ( )
		{
			InitializeComponent ( );
		} // end TextAnalyzerForm

		/// <summary>
		/// When the form loads, get the user information and set the date/time label
		/// </summary>
		/// <param name="sender">The object that originates the event</param>
		/// <param name="e">The instance of the event that holds event information</param>
		private void TextAnalyzerForm_Load (object sender, EventArgs e)
		{
			GetUserInfo ( );

			toolStripStatusLabelStats.Text = DateTime.Today.ToLongDateString ( );
		} // end TextAnalyzerForm_Load
		#endregion

		#region Open Text File
		/// <summary>
		/// Opens an open file dialog that allows the user to select a text file for analysis
		/// </summary>
		/// <param name="sender">The open file button in the File menu</param>
		/// <param name="e">The instance of the event that contains the event information</param>
		private void OpenTextFileToolStripMenuItem_Click (object sender, EventArgs e)
		{
			// Setup an open file dialog
			OpenFileDialog dlg = new OpenFileDialog ( );
			dlg.Filter = "text files|*.txt;*.text|all files|*.*";
			dlg.InitialDirectory = @"..\..\TextFiles";
			dlg.Title = "Open a Text File";

			// Try to get the text file from the dialog
			if (dlg.ShowDialog ( ) == DialogResult.OK)
				path = dlg.FileName;
			else
			{
				MessageBox.Show (null, "No file selected. You must select a text file to use the " +
					"Text Analysis Toolkit.", "No File Selected", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			text = new Text (path);
			words = new Words (text);
			sentences = new SentenceList (text);
			paragraphs = new ParagraphList (text);

			// Fill the tabs with information from the text file
			FillOriginalText ( );
			FillTokens ( );
			FillDistinctWords ( );
			FillSentences ( );
			FillParagraphs ( );

			// User can now select tabs
			tabControls.Enabled = true;
		} // end OpenTextFileToolStripMenuItem_Click
		#endregion

		#region Get User Info
		/// <summary>
		/// Gets the user information.
		/// </summary>
		private void GetUserInfo ( )
		{
			info = new UserInfo ( );

			while (true)
			{
				if (DialogResult.Cancel != info.ShowDialog ( ))
				{
					// Check if info was validated
					if (string.IsNullOrEmpty (info.User.Email) || 
						string.IsNullOrEmpty (info.User.Phone))
						continue;
					else
						break;
				}
				else
				{
					MessageBox.Show (this, "User information not captured.", "No User",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;
				}
			}
		} // end GetUserInfo
		#endregion

		#region Fill Original Text Tab
		/// <summary>
		/// Fills the original text tab, displaying the original text from file selected by user;
		///		also updates status strip
		/// </summary>
		private void FillOriginalText ( )
		{
			// Format original text for display and replace newline characters
			string txt = FormatText (text.OriginalText, rightMargin: 75);
			txt = txt.Replace ("\n", "\r\n");
			originalTextBox.Text = txt;

			// Determine when file name starts and discard the preceding path
			int col = path.LastIndexOf (@"\");
			string fileName = path.Substring (col + 1);
			toolStripStatusLabelFileInfo.Text = $"File: {fileName}";

			toolStripStatusLabelStats.Text = $"Tokens: {text.Tokens.Count}  |  Distinct Words: " +
				$"{words.Count}  |  Sentences: {sentences.NumSentences}  |  Paragraphs: " +
				$"{paragraphs.NumParagraphs}";

		} // end FillOriginalText
		#endregion

		#region Fill Tokens
		/// <summary>
		/// Fills the tokens list in the token tab of the program
		/// </summary>
		private void FillTokens ( )
		{
			foreach (string token in text.Tokens)
			{
				if (token == "\n")
				{
					tokenListBox.Items.Add ("<newline character>");
				}
				else
				{
					tokenListBox.Items.Add (token);
				}
			}
		} // end FillTokens
		#endregion

		#region Fill Distinct Words
		/// <summary>
		/// Fills the distinct words in the distinct words tab
		/// </summary>
		private void FillDistinctWords ( )
		{
			foreach (DistinctWord word in words.WordList)
			{
				distinctWordListBox.Items.Add (word.ToString ( ));
			}
		} // end FillDistinctWords
		#endregion

		#region Sentence Methods
		/// <summary>
		/// Fills the sentence information in the sentences tab
		/// </summary>
		private void FillSentences ( )
		{
			sentencesUpDown.Maximum = sentences.NumSentences;

			// Set sentence text box with formatted sentence
			string txt = sentences.Sentences[0].ToString ( );
			txt = txt.Replace ("\n", "\r\n");
			sentenceTextBox.Text = txt;

			numWordsSentencesText.Text = sentences.Sentences[0].WordCount.ToString ( );

			// Round average word length to two decimal places
			double avgWordLength = sentences.Sentences[0].AvgWordLength;
			avgWordLengthText.Text = $"{avgWordLength:#.##}";
		} // end FillSentences

		/// <summary>
		/// Display a new sentence corresponding with the value from the NumericUpDown box
		/// </summary>
		/// <param name="sender">The NumericUpDown box sending event</param>
		/// <param name="e">The event instance holding event information</param>
		private void SentencesUpDown_ValueChanged (object sender, EventArgs e)
		{
			NumericUpDown n = (NumericUpDown) sender;

			int index = (int) n.Value;

			// Set sentence text box with formatted sentence
			string txt = sentences.Sentences[index - 1].ToString ( );
			txt = txt.Replace ("\n", "\r\n");
			sentenceTextBox.Text = txt;

			numWordsSentencesText.Text = sentences.Sentences[index - 1].WordCount.ToString ( );

			// Round average word length to two decimal places
			double avgWordLength = sentences.Sentences[index - 1].AvgWordLength;
			avgWordLengthText.Text = $"{avgWordLength:#.##}";
		} // end SentencesUpDown_ValueChanged

		/// <summary>
		/// Updates sentence to previous sentence
		/// </summary>
		/// <param name="sender">The button sending the event</param>
		/// <param name="e">The event instance holding event information</param>
		private void PreviousSentenceButton_Click (object sender, EventArgs e)
		{
			if (sentencesUpDown.Value > sentencesUpDown.Minimum)
				sentencesUpDown.Value--;
		} // end PreviousSentenceButton_Click

		/// <summary>
		/// Updates sentence to previous sentence
		/// </summary>
		/// <param name="sender">The button sending the event</param>
		/// <param name="e">The event instance holding event information</param>
		private void NextSentenceButton_Click (object sender, EventArgs e)
		{
			if (sentencesUpDown.Value < sentencesUpDown.Maximum)
				sentencesUpDown.Value++;
		} // end NextSentenceButton_Click
		#endregion

		#region Paragraph Methods
		/// <summary>
		/// Fills the paragraph information in the paragraphs tab
		/// </summary>
		private void FillParagraphs ( )
		{
			paragraphsUpDown.Maximum = paragraphs.NumParagraphs;

			// Set paragraph text box with formatted paragraph
			string txt = paragraphs.Paragraphs[0].ToString ( );
			txt = txt.Replace ("\n", "\r\n");
			paragraphTextBox.Text = txt;

			numWordsParagraphsText.Text = paragraphs.Paragraphs[0].WordCount.ToString ( );
			numSentencesText.Text = paragraphs.Paragraphs[0].NumSentences.ToString ( );

			// Round average number of words to two decimal places
			double avgNumWords = paragraphs.Paragraphs[0].AvgSentenceLength;
			avgWordsText.Text = $"{avgNumWords:#.##}";
		} // end FillParagraphs

		/// <summary>
		/// Display a new paragraph corresponding with the value from the NumericUpDown box
		/// </summary>
		/// <param name="sender">The NumericUpDown box sending event</param>
		/// <param name="e">The event instance holding event information</param>
		private void ParagraphsUpDown_ValueChanged (object sender, EventArgs e)
		{
			NumericUpDown n = (NumericUpDown) sender;

			int index = (int) n.Value;

			// Set paragraph text box with formatted paragraph
			string txt = paragraphs.Paragraphs[index - 1].ToString ( );
			txt = txt.Replace ("\n", "\r\n");
			paragraphTextBox.Text = txt;

			numWordsParagraphsText.Text = paragraphs.Paragraphs[index - 1].WordCount.ToString ( );
			numSentencesText.Text = paragraphs.Paragraphs[index - 1].NumSentences.ToString ( );

			// Round average number of words to two decimal places
			double avgNumWords = paragraphs.Paragraphs[index - 1].AvgSentenceLength;
			avgWordsText.Text = $"{avgNumWords:#.##}";
		} // end ParagraphsUpDown_ValueChanged

		/// <summary>
		/// Updates paragraph to previous paragraph
		/// </summary>
		/// <param name="sender">The button that is clicked</param>
		/// <param name="e">The event instance holding event information</param>
		private void PreviousParagraphButton_Click (object sender, EventArgs e)
		{
			if (paragraphsUpDown.Value > paragraphsUpDown.Minimum)
				paragraphsUpDown.Value--;
		} // end PreviousParagraphButton_Click

		/// <summary>
		/// Updates paragraph to next paragraph
		/// </summary>
		/// <param name="sender">The button that is clicked</param>
		/// <param name="e">The event instance holding event information</param>
		private void NextParagraphButton_Click (object sender, EventArgs e)
		{
			if (paragraphsUpDown.Value < paragraphsUpDown.Maximum)
				paragraphsUpDown.Value++;
		} // end NextParagraphButton_Click
		#endregion

		#region Exit Message	
		/// <summary>
		/// Displays an exit message when user closes program in any way
		/// </summary>
		/// <param name="sender">The object that is closing the form</param>
		/// <param name="e">The event instance that holds information about the event</param>
		private void TextAnalyzerForm_FormClosing (object sender, FormClosingEventArgs e)
		{
			string msg = string.Empty;

			if (info.User != null)
			{
				msg = $"I hope you found this program useful, {info.UserName.First}. " +
					$"I have emailed your invoice for the use of this program to you " +
					$"at {info.User.Email}. The total due is $100.00.\n\nPlease remit " +
					$"immediately.";
			}
			else
			{
				msg = "I hope you found this program useful. Unforunately, you failed " +
					"to provide contact information and there is no place to send " +
					"the bill.\n\nPlease enter you contact information next time.";
			}

			MessageBox.Show (msg, "Goodbye and Thank You", MessageBoxButtons.OK, 
				MessageBoxIcon.Information);
		} // end TextAnalyzerForm_FormClosing
		

		/// <summary>
		/// Handles the Click event of the ExitToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ExitToolStripMenuItem_Click (object sender, EventArgs e)
		{
			this.Close ( );
		} // end ExitToolStripMenuItem_Click
		#endregion

		#region Show About
		/// <summary>
		/// Shows the about box form displaying program information
		/// </summary>
		/// <param name="sender">The button that sent the event</param>
		/// <param name="e">The event instance that holds event data</param>
		private void AboutToolStripMenuItem_Click (object sender, EventArgs e)
		{
			about = new AboutBoxForm ( );
			about.ShowDialog ( );
		} // end AboutToolStripMenuItem_Click
		#endregion
	} // end TextAnalyzerForm
}
