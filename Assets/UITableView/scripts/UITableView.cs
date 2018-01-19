using System.Collections.Generic;
using UnityEngine;

public class UITableView : MonoBehaviour {
	public RectTransform tableView;
	public RectTransform view;
    public GameObject tableViewCell;

	public Sprite icon;

	public int cells;

	// Use this for initialization
	void Start () {
		float height = tableView.rect.height;

		if (height < 100 * cells)
		{
			height = 100 * cells;
		}

		view.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
		view.SetPositionAndRotation(new Vector3(0, -height / 2, 0), Quaternion.Euler(0, 0, 0));

		for (int i = 0; i < cells; i++)
		{
			GameObject cell = Instantiate(tableViewCell);
			cell.transform.SetParent(view.transform, false);

			UITableViewCell tableViewCellScript = cell.GetComponent<UITableViewCell>();
			tableViewCellScript.BookTitle = "Book " + (i + 1);
			tableViewCellScript.BookAuthor = "Author";
			tableViewCellScript.SetIcon(icon);
			tableViewCellScript.PageReaded = (i + 1) * 3;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
