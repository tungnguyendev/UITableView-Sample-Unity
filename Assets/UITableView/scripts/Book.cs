
public class Book
{
	private string title;

	public string Title
	{
		get
		{
			return title;
		}
	}

	private string author;

	public string Author
	{
		get
		{
			return author;
		}
	}

	private string category;

	public string Category
	{
		get
		{
			return category;
		}
	}

	private string bookID;

	public string BookID
	{
		get
		{
			return bookID;
		}
	}

	public Book(string title, string author, string category, string bookID)
	{
		this.title = title;
		this.author = author;
		this.category = category;
		this.bookID = bookID;
	}
}
