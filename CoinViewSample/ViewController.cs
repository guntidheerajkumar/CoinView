using System;
using CoinView;
using UIKit;
using CoreGraphics;

namespace CoinViewSample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var view1 = new UIView();
			var view2 = new UIView();

			view1.BackgroundColor = UIColor.Yellow;
			view2.BackgroundColor = UIColor.Blue;
 
			CMSCoinView coinView = new CMSCoinView(view1, view2, new CGRect(30, 30, this.View.Frame.Width - 60, 150));
			coinView.PrimaryView = view1;
			coinView.SecondaryView = view2;
			coinView.SpinTime = 1.0f;
			this.View.AddSubview(coinView);
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}
	}
}
