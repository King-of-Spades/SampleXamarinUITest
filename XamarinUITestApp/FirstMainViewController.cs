using Foundation;
using System;
using System.Collections.Generic;
using Google.MobileAds;
using UIKit;

namespace XamarinUITestApp
{
    public partial class FirstMainViewController : UITableViewController
    {
        Controls.AdControlV1 _ad;

        //BannerView _adView;
        
        public FirstMainViewController(IntPtr handle) 
            : base(handle)
        {
            _ad = new Controls.AdControlV1(handle);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            string[] values = new string[] { "Fencers", "Bouts", "Tab Test" };

            this.TableView.AllowsSelection = true;
            this.TableView.Source = new FirstMainDataSource(values, this);

            //this.TableView.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;
            this.TableView.SeparatorEffect = UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark);

            //this.TableView.TableFooterView.AddSubview(_ad);
            //this.TableView.TableFooterView = _ad;

            // setup banner ad
            //_adView = new BannerView(AdSizeCons.Banner);


            //_adView.AdUnitID = "ca-app-pub-3940256099942544/6300978111";
            //_adView.RootViewController = this;

            //AddBannerAd(_adView);

            //_adView.LoadRequest(request: GetAdRequest());
        }

        void AddBannerAd(BannerView adView)
        {
            adView.TranslatesAutoresizingMaskIntoConstraints = false;

            this.View.Add(adView);

            NSMutableDictionary viewsDictionary = new NSMutableDictionary();
            viewsDictionary.Add(new NSString("ad"), adView);

            NSLayoutConstraint[] constraints = NSLayoutConstraint.FromVisualFormat("|-[ad]-|", NSLayoutFormatOptions.AlignAllBottom, null, viewsDictionary);

            NSLayoutConstraint.ActivateConstraints(constraints);
        }

        Request GetAdRequest()
        {
            return Request.GetDefaultRequest();
        }
    }

}