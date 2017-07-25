using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Foundation;
namespace App1
{
    public class MyDataSource: UITableViewSource
    {
        string[] tableItems;
        string cellIdentifier = "TableCell";
        public MyDataSource(string[] items)
        {
            tableItems = items;
            

        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            string item = tableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier); }

            cell.TextLabel.Text = item;

            return cell;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }
    }
}
