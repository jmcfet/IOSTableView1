using Foundation;
using GymPal.Core.Models;
using GymPal.Core.Service;
using System;
using System.Collections.Generic;
using UIKit;

namespace App1
{
    public partial class machinesTableController : UITableViewController
    {
        GympalService service = new GympalService();
        public machinesTableController (IntPtr handle) : base (handle)
        {
            
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            List<Machine> listallMachines = service.GetAllMachines();
            TableView.Source = new machinesDataSource(listallMachines, this);
            this.NavigationItem.Title = "Machines";
        }
    }
}