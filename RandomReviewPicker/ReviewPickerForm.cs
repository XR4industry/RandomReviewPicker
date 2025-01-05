namespace RandomReviewPicker;

public partial class ReviewPickerForm : Form
{
	public ReviewPickerForm()
	{
		InitializeComponent();
	}

	string _folder;
	ReviewPicker _reviewPicker;


	private void PickFolderBtn_Click(object sender, EventArgs e)
	{
		using (var fbd = new FolderBrowserDialog())
		{
			DialogResult result = fbd.ShowDialog();

			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				_folder = fbd.SelectedPath;
			}
		}
		_reviewPicker = new ReviewPicker();

		var paths = _reviewPicker.GetScriptFilePaths(_folder);
		_reviewPicker.ScriptInfos = _reviewPicker.GetScriptInfo(paths);
		
	}


	private void PickRandomBtn_Click(object sender, EventArgs e)
	{
		var reviewinfo = _reviewPicker.Pick(_reviewPicker.ScriptInfos);

		Console.WriteLine(reviewinfo);
	}
}
