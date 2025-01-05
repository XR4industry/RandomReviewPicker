namespace RandomReviewPicker;

public class ScriptFileInfo
{
	public required string Path { get; set; } = "path";
	public required string Name { get; set; } = "name";
	public Review? ScriptReview { get; set; }
	public int Lines { get; set; }
	public int Characters { get; set; }	
}