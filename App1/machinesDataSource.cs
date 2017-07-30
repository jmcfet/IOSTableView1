using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using GymPal.Core.Models;
namespace App1
{
    public class machinesDataSource : UITableViewSource
    {
        List<Machine> machines;
        NSString cellId = new NSString("machine");

        public machinesDataSource(List<Machine> machines, UITableViewController caller)
        {

            this.machines = machines;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return machines.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellId) as UITableViewCell;
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellId);
            }
            Machine machine = machines[indexPath.Row];
            cell.TextLabel.Text = machine.Name;
            cell.ImageView.Image = UIImage.FromFile("Images/" + machine.Name + ".jpg");
            return cell;
        }
        public Machine GetItem(int id)
        {
            return machines[id];
        }
    

    }
}
