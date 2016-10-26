using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace CoinView
{
	// @interface CMSCoinView : UIView
	[BaseType(typeof(UIView))]
	interface CMSCoinView
	{
		// -(id)initWithPrimaryView:(UIView *)view1 andSecondaryView:(UIView *)view2 inFrame:(CGRect)frame;
		[Export("initWithPrimaryView:andSecondaryView:inFrame:")]
		IntPtr Constructor(UIView view1, UIView view2, CGRect frame);

		// @property (retain, nonatomic) UIView * primaryView;
		[Export("primaryView", ArgumentSemantic.Retain)]
		UIView PrimaryView { get; set; }

		// @property (retain, nonatomic) UIView * secondaryView;
		[Export("secondaryView", ArgumentSemantic.Retain)]
		UIView SecondaryView { get; set; }

		// @property float spinTime;
		[Export("spinTime")]
		float SpinTime { get; set; }
	}
}
