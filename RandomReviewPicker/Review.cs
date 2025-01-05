namespace RandomReviewPicker;
public class Review
{
	public string? Author;
	public string? Description;
	public int? Score;

	public string? PositiveRemarks;
	public string? NegativeRemarks;

	public DateTime? ReviewDate;

	internal static Review GetReview(string path) => new();
}
