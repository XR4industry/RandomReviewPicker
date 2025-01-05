
namespace RandomReviewPicker;

partial class ReviewPickerForm
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		PickFolderBtn = new Button();
		FolderLbl = new Label();
		FolderStatsLbl = new Label();
		listBox1 = new ListBox();
		textBox1 = new TextBox();
		PickRandomBtn = new Button();
		SuspendLayout();
		// 
		// PickFolderBtn
		// 
		PickFolderBtn.Location = new Point(12, 12);
		PickFolderBtn.Name = "PickFolderBtn";
		PickFolderBtn.Size = new Size(75, 23);
		PickFolderBtn.TabIndex = 0;
		PickFolderBtn.Text = "Pick Folder";
		PickFolderBtn.UseVisualStyleBackColor = true;
		PickFolderBtn.Click += this.PickFolderBtn_Click;
		// 
		// FolderLbl
		// 
		FolderLbl.AutoSize = true;
		FolderLbl.Location = new Point(93, 16);
		FolderLbl.Name = "FolderLbl";
		FolderLbl.Size = new Size(38, 15);
		FolderLbl.TabIndex = 1;
		FolderLbl.Text = "label1";
		// 
		// FolderStatsLbl
		// 
		FolderStatsLbl.AutoSize = true;
		FolderStatsLbl.Location = new Point(12, 38);
		FolderStatsLbl.Name = "FolderStatsLbl";
		FolderStatsLbl.Size = new Size(81, 15);
		FolderStatsLbl.TabIndex = 2;
		FolderStatsLbl.Text = "FolderStatsLbl";
		// 
		// listBox1
		// 
		listBox1.FormattingEnabled = true;
		listBox1.ItemHeight = 15;
		listBox1.Location = new Point(12, 126);
		listBox1.Name = "listBox1";
		listBox1.Size = new Size(347, 214);
		listBox1.TabIndex = 3;
		// 
		// textBox1
		// 
		textBox1.Location = new Point(438, 16);
		textBox1.Name = "textBox1";
		textBox1.Size = new Size(100, 23);
		textBox1.TabIndex = 4;
		// 
		// PickRandomBtn
		// 
		PickRandomBtn.Location = new Point(12, 68);
		PickRandomBtn.Name = "PickRandomBtn";
		PickRandomBtn.Size = new Size(347, 52);
		PickRandomBtn.TabIndex = 5;
		PickRandomBtn.Text = "Random!";
		PickRandomBtn.UseVisualStyleBackColor = true;
		PickRandomBtn.Click += this.PickRandomBtn_Click;
		// 
		// ReviewPickerForm
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(822, 353);
		Controls.Add(PickRandomBtn);
		Controls.Add(textBox1);
		Controls.Add(listBox1);
		Controls.Add(FolderStatsLbl);
		Controls.Add(FolderLbl);
		Controls.Add(PickFolderBtn);
		Name = "ReviewPickerForm";
		Text = "Review Picker";
		ResumeLayout(false);
		PerformLayout();
	}

	
	#endregion

	private Button PickFolderBtn;
	private Label FolderLbl;
	private Label FolderStatsLbl;
	private ListBox listBox1;
	private TextBox textBox1;
	private Button PickRandomBtn;
}
