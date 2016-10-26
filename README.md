# Coin View
> Coin View Flip Animation

```
var view1 = new UIView();
var view2 = new UIView();

view1.BackgroundColor = UIColor.Yellow;
view2.BackgroundColor = UIColor.Blue;

CMSCoinView coinView = new CMSCoinView(view1, view2, new CGRect(30, 30, this.View.Frame.Width - 60, 150));
coinView.PrimaryView = view1;
coinView.SecondaryView = view2;
coinView.SpinTime = 1.0f;
this.View.AddSubview(coinView);
```
