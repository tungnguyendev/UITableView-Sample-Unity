using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UITableViewCell : MonoBehaviour
{
	public Text title;
	public Text author;
	public Text readed;
	public Image icon;
	public Image line;

	private string bookTitle;

	public string BookTitle
	{
		set
		{
			bookTitle = value;
			title.text = bookTitle;
		}
	}

	private string bookAuthor;

	public string BookAuthor
	{
		set
		{
			bookAuthor = value;
			author.text = bookAuthor;
		}
	}


	private string bookCategory;

	public string BookCategory
	{
		set
		{
			bookCategory = value;
		}
	}


	private int pageReaded;

	public int PageReaded
	{
		set
		{
			pageReaded = value;
			readed.text = pageReaded.ToString();
		}
	}

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Read_Action()
	{
		print("Click " + bookTitle);
	}

	public void SetIcon(Sprite ico)
	{
		icon.sprite = ico;
	}
}
