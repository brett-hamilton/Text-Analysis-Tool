﻿///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 2 - Text Analysis GUI
//	File Name:         TextAnalyzerForm.Designer.cs
//	Description:       Required code for the main form, generated by Visual Studio, provides necessary
//							code for form controls and display
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Monday, September 30, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace TextAnalysis
{
	partial class TextAnalyzerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAnalyzerForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControls = new System.Windows.Forms.TabControl();
			this.originalTextTab = new System.Windows.Forms.TabPage();
			this.originalTextBox = new System.Windows.Forms.TextBox();
			this.tokensTab = new System.Windows.Forms.TabPage();
			this.tokensFoundLabel = new System.Windows.Forms.Label();
			this.tokenListBox = new System.Windows.Forms.ListBox();
			this.distinctWordsTab = new System.Windows.Forms.TabPage();
			this.occurencesLabel = new System.Windows.Forms.Label();
			this.wordsLabel = new System.Windows.Forms.Label();
			this.distinctWordListBox = new System.Windows.Forms.ListBox();
			this.sentencesTab = new System.Windows.Forms.TabPage();
			this.nextSentenceButton = new System.Windows.Forms.Button();
			this.previousSentenceButton = new System.Windows.Forms.Button();
			this.avgWordLengthText = new System.Windows.Forms.TextBox();
			this.numWordsSentencesText = new System.Windows.Forms.TextBox();
			this.avgWordLengthLabel = new System.Windows.Forms.Label();
			this.numWordsSentenceLabel = new System.Windows.Forms.Label();
			this.sentencesUpDown = new System.Windows.Forms.NumericUpDown();
			this.sentencesLabel = new System.Windows.Forms.Label();
			this.sentenceTextBox = new System.Windows.Forms.TextBox();
			this.paragraphsTab = new System.Windows.Forms.TabPage();
			this.nextParagraphButton = new System.Windows.Forms.Button();
			this.previousParagraphButton = new System.Windows.Forms.Button();
			this.avgWordsText = new System.Windows.Forms.TextBox();
			this.numWordsParagraphsText = new System.Windows.Forms.TextBox();
			this.numSentencesText = new System.Windows.Forms.TextBox();
			this.avgWordsLabel = new System.Windows.Forms.Label();
			this.numWordsParagraphLabel = new System.Windows.Forms.Label();
			this.numSentencesLabel = new System.Windows.Forms.Label();
			this.paragraphsLabel = new System.Windows.Forms.Label();
			this.paragraphsUpDown = new System.Windows.Forms.NumericUpDown();
			this.paragraphTextBox = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelFileInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelStats = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip.SuspendLayout();
			this.tabControls.SuspendLayout();
			this.originalTextTab.SuspendLayout();
			this.tokensTab.SuspendLayout();
			this.distinctWordsTab.SuspendLayout();
			this.sentencesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sentencesUpDown)).BeginInit();
			this.paragraphsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paragraphsUpDown)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Font = new System.Drawing.Font("Calibri", 9F);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(604, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openTextFileToolStripMenuItem
			// 
			this.openTextFileToolStripMenuItem.Image = global::Project2.Properties.Resources.OpenFile_16x;
			this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
			this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openTextFileToolStripMenuItem.Text = "&Open Text File";
			this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTextFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::Project2.Properties.Resources.CloseSolution_16x;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::Project2.Properties.Resources.StatusInfoTip_16x;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// tabControls
			// 
			this.tabControls.Controls.Add(this.originalTextTab);
			this.tabControls.Controls.Add(this.tokensTab);
			this.tabControls.Controls.Add(this.distinctWordsTab);
			this.tabControls.Controls.Add(this.sentencesTab);
			this.tabControls.Controls.Add(this.paragraphsTab);
			this.tabControls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControls.Enabled = false;
			this.tabControls.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControls.Location = new System.Drawing.Point(0, 24);
			this.tabControls.Name = "tabControls";
			this.tabControls.SelectedIndex = 0;
			this.tabControls.Size = new System.Drawing.Size(604, 407);
			this.tabControls.TabIndex = 1;
			// 
			// originalTextTab
			// 
			this.originalTextTab.Controls.Add(this.originalTextBox);
			this.originalTextTab.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.originalTextTab.Location = new System.Drawing.Point(4, 27);
			this.originalTextTab.Name = "originalTextTab";
			this.originalTextTab.Padding = new System.Windows.Forms.Padding(3);
			this.originalTextTab.Size = new System.Drawing.Size(596, 376);
			this.originalTextTab.TabIndex = 0;
			this.originalTextTab.Text = "Original Text";
			this.originalTextTab.UseVisualStyleBackColor = true;
			// 
			// originalTextBox
			// 
			this.originalTextBox.AcceptsReturn = true;
			this.originalTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.originalTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.originalTextBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.originalTextBox.Location = new System.Drawing.Point(3, 3);
			this.originalTextBox.Multiline = true;
			this.originalTextBox.Name = "originalTextBox";
			this.originalTextBox.ReadOnly = true;
			this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.originalTextBox.Size = new System.Drawing.Size(590, 370);
			this.originalTextBox.TabIndex = 0;
			this.originalTextBox.Text = "Please select a text file for analysis using the File menu above.";
			this.originalTextBox.WordWrap = false;
			// 
			// tokensTab
			// 
			this.tokensTab.Controls.Add(this.tokensFoundLabel);
			this.tokensTab.Controls.Add(this.tokenListBox);
			this.tokensTab.Location = new System.Drawing.Point(4, 27);
			this.tokensTab.Name = "tokensTab";
			this.tokensTab.Padding = new System.Windows.Forms.Padding(3);
			this.tokensTab.Size = new System.Drawing.Size(596, 376);
			this.tokensTab.TabIndex = 1;
			this.tokensTab.Text = "Tokens";
			this.tokensTab.UseVisualStyleBackColor = true;
			// 
			// tokensFoundLabel
			// 
			this.tokensFoundLabel.AutoSize = true;
			this.tokensFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tokensFoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.tokensFoundLabel.Location = new System.Drawing.Point(218, 23);
			this.tokensFoundLabel.Name = "tokensFoundLabel";
			this.tokensFoundLabel.Size = new System.Drawing.Size(161, 26);
			this.tokensFoundLabel.TabIndex = 1;
			this.tokensFoundLabel.Text = "Tokens Found";
			// 
			// tokenListBox
			// 
			this.tokenListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tokenListBox.BackColor = System.Drawing.SystemColors.Info;
			this.tokenListBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tokenListBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tokenListBox.FormattingEnabled = true;
			this.tokenListBox.ItemHeight = 18;
			this.tokenListBox.Location = new System.Drawing.Point(176, 55);
			this.tokenListBox.Name = "tokenListBox";
			this.tokenListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.tokenListBox.Size = new System.Drawing.Size(245, 292);
			this.tokenListBox.TabIndex = 0;
			// 
			// distinctWordsTab
			// 
			this.distinctWordsTab.Controls.Add(this.occurencesLabel);
			this.distinctWordsTab.Controls.Add(this.wordsLabel);
			this.distinctWordsTab.Controls.Add(this.distinctWordListBox);
			this.distinctWordsTab.Location = new System.Drawing.Point(4, 27);
			this.distinctWordsTab.Name = "distinctWordsTab";
			this.distinctWordsTab.Padding = new System.Windows.Forms.Padding(3);
			this.distinctWordsTab.Size = new System.Drawing.Size(596, 376);
			this.distinctWordsTab.TabIndex = 2;
			this.distinctWordsTab.Text = "Distinct Words";
			this.distinctWordsTab.UseVisualStyleBackColor = true;
			// 
			// occurencesLabel
			// 
			this.occurencesLabel.AutoSize = true;
			this.occurencesLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.occurencesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.occurencesLabel.Location = new System.Drawing.Point(298, 20);
			this.occurencesLabel.Name = "occurencesLabel";
			this.occurencesLabel.Size = new System.Drawing.Size(142, 25);
			this.occurencesLabel.TabIndex = 2;
			this.occurencesLabel.Text = "Occurences";
			// 
			// wordsLabel
			// 
			this.wordsLabel.AutoSize = true;
			this.wordsLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wordsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.wordsLabel.Location = new System.Drawing.Point(156, 20);
			this.wordsLabel.Name = "wordsLabel";
			this.wordsLabel.Size = new System.Drawing.Size(77, 25);
			this.wordsLabel.TabIndex = 1;
			this.wordsLabel.Text = "Words";
			// 
			// distinctWordListBox
			// 
			this.distinctWordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.distinctWordListBox.BackColor = System.Drawing.SystemColors.Info;
			this.distinctWordListBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distinctWordListBox.FormattingEnabled = true;
			this.distinctWordListBox.ItemHeight = 16;
			this.distinctWordListBox.Location = new System.Drawing.Point(161, 48);
			this.distinctWordListBox.Name = "distinctWordListBox";
			this.distinctWordListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.distinctWordListBox.Size = new System.Drawing.Size(279, 308);
			this.distinctWordListBox.TabIndex = 0;
			// 
			// sentencesTab
			// 
			this.sentencesTab.Controls.Add(this.nextSentenceButton);
			this.sentencesTab.Controls.Add(this.previousSentenceButton);
			this.sentencesTab.Controls.Add(this.avgWordLengthText);
			this.sentencesTab.Controls.Add(this.numWordsSentencesText);
			this.sentencesTab.Controls.Add(this.avgWordLengthLabel);
			this.sentencesTab.Controls.Add(this.numWordsSentenceLabel);
			this.sentencesTab.Controls.Add(this.sentencesUpDown);
			this.sentencesTab.Controls.Add(this.sentencesLabel);
			this.sentencesTab.Controls.Add(this.sentenceTextBox);
			this.sentencesTab.Location = new System.Drawing.Point(4, 27);
			this.sentencesTab.Name = "sentencesTab";
			this.sentencesTab.Padding = new System.Windows.Forms.Padding(3);
			this.sentencesTab.Size = new System.Drawing.Size(596, 376);
			this.sentencesTab.TabIndex = 3;
			this.sentencesTab.Text = "Sentences";
			this.sentencesTab.UseVisualStyleBackColor = true;
			// 
			// nextSentenceButton
			// 
			this.nextSentenceButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextSentenceButton.Image = global::Project2.Properties.Resources.Next_16x;
			this.nextSentenceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.nextSentenceButton.Location = new System.Drawing.Point(313, 330);
			this.nextSentenceButton.Name = "nextSentenceButton";
			this.nextSentenceButton.Size = new System.Drawing.Size(124, 33);
			this.nextSentenceButton.TabIndex = 8;
			this.nextSentenceButton.Text = "Next";
			this.nextSentenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.nextSentenceButton.UseVisualStyleBackColor = true;
			this.nextSentenceButton.Click += new System.EventHandler(this.NextSentenceButton_Click);
			// 
			// previousSentenceButton
			// 
			this.previousSentenceButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.previousSentenceButton.Image = global::Project2.Properties.Resources.Previous_16x;
			this.previousSentenceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.previousSentenceButton.Location = new System.Drawing.Point(162, 330);
			this.previousSentenceButton.Name = "previousSentenceButton";
			this.previousSentenceButton.Size = new System.Drawing.Size(124, 33);
			this.previousSentenceButton.TabIndex = 7;
			this.previousSentenceButton.Text = "Previous";
			this.previousSentenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.previousSentenceButton.UseVisualStyleBackColor = true;
			this.previousSentenceButton.Click += new System.EventHandler(this.PreviousSentenceButton_Click);
			// 
			// avgWordLengthText
			// 
			this.avgWordLengthText.Location = new System.Drawing.Point(363, 271);
			this.avgWordLengthText.Name = "avgWordLengthText";
			this.avgWordLengthText.ReadOnly = true;
			this.avgWordLengthText.Size = new System.Drawing.Size(74, 25);
			this.avgWordLengthText.TabIndex = 6;
			this.avgWordLengthText.TabStop = false;
			this.avgWordLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numWordsSentencesText
			// 
			this.numWordsSentencesText.Location = new System.Drawing.Point(363, 235);
			this.numWordsSentencesText.Name = "numWordsSentencesText";
			this.numWordsSentencesText.ReadOnly = true;
			this.numWordsSentencesText.Size = new System.Drawing.Size(74, 25);
			this.numWordsSentencesText.TabIndex = 4;
			this.numWordsSentencesText.TabStop = false;
			this.numWordsSentencesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// avgWordLengthLabel
			// 
			this.avgWordLengthLabel.AutoSize = true;
			this.avgWordLengthLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.avgWordLengthLabel.Location = new System.Drawing.Point(159, 273);
			this.avgWordLengthLabel.Name = "avgWordLengthLabel";
			this.avgWordLengthLabel.Size = new System.Drawing.Size(166, 22);
			this.avgWordLengthLabel.TabIndex = 5;
			this.avgWordLengthLabel.Text = "Average Word Length";
			// 
			// numWordsSentenceLabel
			// 
			this.numWordsSentenceLabel.AutoSize = true;
			this.numWordsSentenceLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numWordsSentenceLabel.Location = new System.Drawing.Point(159, 237);
			this.numWordsSentenceLabel.Name = "numWordsSentenceLabel";
			this.numWordsSentenceLabel.Size = new System.Drawing.Size(140, 22);
			this.numWordsSentenceLabel.TabIndex = 3;
			this.numWordsSentenceLabel.Text = "Number of Words";
			// 
			// sentencesUpDown
			// 
			this.sentencesUpDown.ForeColor = System.Drawing.Color.Red;
			this.sentencesUpDown.Location = new System.Drawing.Point(354, 27);
			this.sentencesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.sentencesUpDown.Name = "sentencesUpDown";
			this.sentencesUpDown.Size = new System.Drawing.Size(59, 25);
			this.sentencesUpDown.TabIndex = 1;
			this.sentencesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.sentencesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.sentencesUpDown.ValueChanged += new System.EventHandler(this.SentencesUpDown_ValueChanged);
			// 
			// sentencesLabel
			// 
			this.sentencesLabel.AutoSize = true;
			this.sentencesLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sentencesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.sentencesLabel.Location = new System.Drawing.Point(183, 27);
			this.sentencesLabel.Name = "sentencesLabel";
			this.sentencesLabel.Size = new System.Drawing.Size(152, 24);
			this.sentencesLabel.TabIndex = 0;
			this.sentencesLabel.Text = "Display Sentence";
			// 
			// sentenceTextBox
			// 
			this.sentenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sentenceTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.sentenceTextBox.ForeColor = System.Drawing.Color.Navy;
			this.sentenceTextBox.Location = new System.Drawing.Point(8, 62);
			this.sentenceTextBox.Multiline = true;
			this.sentenceTextBox.Name = "sentenceTextBox";
			this.sentenceTextBox.ReadOnly = true;
			this.sentenceTextBox.Size = new System.Drawing.Size(580, 140);
			this.sentenceTextBox.TabIndex = 2;
			this.sentenceTextBox.TabStop = false;
			// 
			// paragraphsTab
			// 
			this.paragraphsTab.Controls.Add(this.nextParagraphButton);
			this.paragraphsTab.Controls.Add(this.previousParagraphButton);
			this.paragraphsTab.Controls.Add(this.avgWordsText);
			this.paragraphsTab.Controls.Add(this.numWordsParagraphsText);
			this.paragraphsTab.Controls.Add(this.numSentencesText);
			this.paragraphsTab.Controls.Add(this.avgWordsLabel);
			this.paragraphsTab.Controls.Add(this.numWordsParagraphLabel);
			this.paragraphsTab.Controls.Add(this.numSentencesLabel);
			this.paragraphsTab.Controls.Add(this.paragraphsLabel);
			this.paragraphsTab.Controls.Add(this.paragraphsUpDown);
			this.paragraphsTab.Controls.Add(this.paragraphTextBox);
			this.paragraphsTab.Location = new System.Drawing.Point(4, 27);
			this.paragraphsTab.Name = "paragraphsTab";
			this.paragraphsTab.Padding = new System.Windows.Forms.Padding(3);
			this.paragraphsTab.Size = new System.Drawing.Size(596, 376);
			this.paragraphsTab.TabIndex = 4;
			this.paragraphsTab.Text = "Paragraphs";
			this.paragraphsTab.UseVisualStyleBackColor = true;
			// 
			// nextParagraphButton
			// 
			this.nextParagraphButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextParagraphButton.Image = global::Project2.Properties.Resources.Next_16x;
			this.nextParagraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.nextParagraphButton.Location = new System.Drawing.Point(313, 330);
			this.nextParagraphButton.Name = "nextParagraphButton";
			this.nextParagraphButton.Size = new System.Drawing.Size(124, 33);
			this.nextParagraphButton.TabIndex = 11;
			this.nextParagraphButton.Text = "Next";
			this.nextParagraphButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.nextParagraphButton.UseVisualStyleBackColor = true;
			this.nextParagraphButton.Click += new System.EventHandler(this.NextParagraphButton_Click);
			// 
			// previousParagraphButton
			// 
			this.previousParagraphButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.previousParagraphButton.Image = global::Project2.Properties.Resources.Previous_16x;
			this.previousParagraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.previousParagraphButton.Location = new System.Drawing.Point(162, 330);
			this.previousParagraphButton.Name = "previousParagraphButton";
			this.previousParagraphButton.Size = new System.Drawing.Size(124, 33);
			this.previousParagraphButton.TabIndex = 10;
			this.previousParagraphButton.Text = "Previous";
			this.previousParagraphButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.previousParagraphButton.UseVisualStyleBackColor = true;
			this.previousParagraphButton.Click += new System.EventHandler(this.PreviousParagraphButton_Click);
			// 
			// avgWordsText
			// 
			this.avgWordsText.Location = new System.Drawing.Point(363, 292);
			this.avgWordsText.Name = "avgWordsText";
			this.avgWordsText.ReadOnly = true;
			this.avgWordsText.Size = new System.Drawing.Size(74, 25);
			this.avgWordsText.TabIndex = 8;
			this.avgWordsText.TabStop = false;
			this.avgWordsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numWordsParagraphsText
			// 
			this.numWordsParagraphsText.Location = new System.Drawing.Point(363, 258);
			this.numWordsParagraphsText.Name = "numWordsParagraphsText";
			this.numWordsParagraphsText.ReadOnly = true;
			this.numWordsParagraphsText.Size = new System.Drawing.Size(74, 25);
			this.numWordsParagraphsText.TabIndex = 6;
			this.numWordsParagraphsText.TabStop = false;
			this.numWordsParagraphsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numSentencesText
			// 
			this.numSentencesText.Location = new System.Drawing.Point(363, 224);
			this.numSentencesText.Name = "numSentencesText";
			this.numSentencesText.ReadOnly = true;
			this.numSentencesText.Size = new System.Drawing.Size(74, 25);
			this.numSentencesText.TabIndex = 4;
			this.numSentencesText.TabStop = false;
			this.numSentencesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// avgWordsLabel
			// 
			this.avgWordsLabel.AutoSize = true;
			this.avgWordsLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.avgWordsLabel.Location = new System.Drawing.Point(159, 294);
			this.avgWordsLabel.Name = "avgWordsLabel";
			this.avgWordsLabel.Size = new System.Drawing.Size(120, 22);
			this.avgWordsLabel.TabIndex = 7;
			this.avgWordsLabel.Text = "Average Words";
			// 
			// numWordsParagraphLabel
			// 
			this.numWordsParagraphLabel.AutoSize = true;
			this.numWordsParagraphLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numWordsParagraphLabel.Location = new System.Drawing.Point(159, 260);
			this.numWordsParagraphLabel.Name = "numWordsParagraphLabel";
			this.numWordsParagraphLabel.Size = new System.Drawing.Size(140, 22);
			this.numWordsParagraphLabel.TabIndex = 5;
			this.numWordsParagraphLabel.Text = "Number of Words";
			// 
			// numSentencesLabel
			// 
			this.numSentencesLabel.AutoSize = true;
			this.numSentencesLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numSentencesLabel.Location = new System.Drawing.Point(159, 226);
			this.numSentencesLabel.Name = "numSentencesLabel";
			this.numSentencesLabel.Size = new System.Drawing.Size(167, 22);
			this.numSentencesLabel.TabIndex = 3;
			this.numSentencesLabel.Text = "Number of Sentences";
			// 
			// paragraphsLabel
			// 
			this.paragraphsLabel.AutoSize = true;
			this.paragraphsLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paragraphsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.paragraphsLabel.Location = new System.Drawing.Point(177, 27);
			this.paragraphsLabel.Name = "paragraphsLabel";
			this.paragraphsLabel.Size = new System.Drawing.Size(162, 24);
			this.paragraphsLabel.TabIndex = 0;
			this.paragraphsLabel.Text = "Display Paragraph";
			// 
			// paragraphsUpDown
			// 
			this.paragraphsUpDown.ForeColor = System.Drawing.Color.Red;
			this.paragraphsUpDown.Location = new System.Drawing.Point(354, 27);
			this.paragraphsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.paragraphsUpDown.Name = "paragraphsUpDown";
			this.paragraphsUpDown.Size = new System.Drawing.Size(59, 25);
			this.paragraphsUpDown.TabIndex = 1;
			this.paragraphsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.paragraphsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.paragraphsUpDown.ValueChanged += new System.EventHandler(this.ParagraphsUpDown_ValueChanged);
			// 
			// paragraphTextBox
			// 
			this.paragraphTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paragraphTextBox.BackColor = System.Drawing.SystemColors.Info;
			this.paragraphTextBox.ForeColor = System.Drawing.Color.Navy;
			this.paragraphTextBox.Location = new System.Drawing.Point(8, 62);
			this.paragraphTextBox.Multiline = true;
			this.paragraphTextBox.Name = "paragraphTextBox";
			this.paragraphTextBox.Size = new System.Drawing.Size(580, 140);
			this.paragraphTextBox.TabIndex = 2;
			this.paragraphTextBox.TabStop = false;
			// 
			// statusStrip
			// 
			this.statusStrip.Font = new System.Drawing.Font("Calibri", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFileInfo,
            this.toolStripStatusLabelStats});
			this.statusStrip.Location = new System.Drawing.Point(0, 431);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(604, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabelFileInfo
			// 
			this.toolStripStatusLabelFileInfo.Name = "toolStripStatusLabelFileInfo";
			this.toolStripStatusLabelFileInfo.Size = new System.Drawing.Size(254, 17);
			this.toolStripStatusLabelFileInfo.Text = "Text Analysis Toolkit built Brett Hamilton, Inc.";
			// 
			// toolStripStatusLabelStats
			// 
			this.toolStripStatusLabelStats.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolStripStatusLabelStats.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
			this.toolStripStatusLabelStats.Name = "toolStripStatusLabelStats";
			this.toolStripStatusLabelStats.Size = new System.Drawing.Size(71, 17);
			this.toolStripStatusLabelStats.Text = "Date / Stats";
			// 
			// TextAnalyzerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 453);
			this.Controls.Add(this.tabControls);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "TextAnalyzerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Text Analysis Toolkit";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextAnalyzerForm_FormClosing);
			this.Load += new System.EventHandler(this.TextAnalyzerForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tabControls.ResumeLayout(false);
			this.originalTextTab.ResumeLayout(false);
			this.originalTextTab.PerformLayout();
			this.tokensTab.ResumeLayout(false);
			this.tokensTab.PerformLayout();
			this.distinctWordsTab.ResumeLayout(false);
			this.distinctWordsTab.PerformLayout();
			this.sentencesTab.ResumeLayout(false);
			this.sentencesTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sentencesUpDown)).EndInit();
			this.paragraphsTab.ResumeLayout(false);
			this.paragraphsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.paragraphsUpDown)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControls;
		private System.Windows.Forms.TabPage originalTextTab;
		private System.Windows.Forms.TabPage tokensTab;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileInfo;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStats;
		private System.Windows.Forms.TextBox originalTextBox;
		private System.Windows.Forms.ListBox tokenListBox;
		private System.Windows.Forms.TabPage distinctWordsTab;
		private System.Windows.Forms.TabPage sentencesTab;
		private System.Windows.Forms.TabPage paragraphsTab;
		private System.Windows.Forms.Label tokensFoundLabel;
		private System.Windows.Forms.ListBox distinctWordListBox;
		private System.Windows.Forms.Label occurencesLabel;
		private System.Windows.Forms.Label wordsLabel;
		private System.Windows.Forms.NumericUpDown sentencesUpDown;
		private System.Windows.Forms.Label sentencesLabel;
		private System.Windows.Forms.TextBox sentenceTextBox;
		private System.Windows.Forms.TextBox avgWordLengthText;
		private System.Windows.Forms.TextBox numWordsSentencesText;
		private System.Windows.Forms.Label avgWordLengthLabel;
		private System.Windows.Forms.Label numWordsSentenceLabel;
		private System.Windows.Forms.Button nextSentenceButton;
		private System.Windows.Forms.Button previousSentenceButton;
		private System.Windows.Forms.TextBox paragraphTextBox;
		private System.Windows.Forms.TextBox avgWordsText;
		private System.Windows.Forms.TextBox numWordsParagraphsText;
		private System.Windows.Forms.TextBox numSentencesText;
		private System.Windows.Forms.Label avgWordsLabel;
		private System.Windows.Forms.Label numWordsParagraphLabel;
		private System.Windows.Forms.Label numSentencesLabel;
		private System.Windows.Forms.Label paragraphsLabel;
		private System.Windows.Forms.NumericUpDown paragraphsUpDown;
		private System.Windows.Forms.Button nextParagraphButton;
		private System.Windows.Forms.Button previousParagraphButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

