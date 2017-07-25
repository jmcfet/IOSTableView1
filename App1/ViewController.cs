using CoreGraphics;
using System;
using System.Collections.Generic;
using UIKit;

namespace App1
{
    public partial class ViewController : UIViewController
    {
        UITableView table;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            List<string> tableItems = new List<string>(){
                "pear",
                "apples",
                "prunes",
                "orange" };
            var width = View.Bounds.Width;
            var height = View.Bounds.Height;

            table = new UITableView(new CGRect(0, 0, width, height));
            table.Source = new MyDataSource(tableItems.ToArray());
            table.AutoresizingMask = UIViewAutoresizing.All;
           
            Add(table);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}