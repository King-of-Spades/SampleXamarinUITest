using System;
using System.ComponentModel;
using Foundation;
using Google.MobileAds;
using UIKit;

namespace XamarinUITestApp.Controls
{


    [Register("AdControl"), DesignTimeVisible(true), Description("A control that can be used to display ads on the screen.")]
    public class AdControlV1 : UIView, IComponent
    {

        BannerView _adBanner;

        public AdControlV1(IntPtr ptr)
            : base(ptr)
        {
        }

        public AdControlV1()
        {
        }

        [Export("AdUnitID"), Browsable(true)]
        public string AdUnitID { get; set; }

        public ISite Site { get; set; }

        public event EventHandler Disposed;

        protected virtual void OnDisposed(EventArgs eventArgs)
        {
            Disposed?.Invoke(this, eventArgs);
        }

        public override void AwakeFromNib()
        {
            Initialize();
        }

        void Initialize()
        {
            if (Site != null && Site.DesignMode)
            {
                return;
            }

            _adBanner = new BannerView(AdSizeCons.Banner)
            {
                AdUnitID = AdUnitID,
                RootViewController = GetVisibleViewController()
            };

            AddBannerAd(_adBanner);

            _adBanner.LoadRequest(Request.GetDefaultRequest());
        }

        void AddBannerAd(BannerView adView)
        {
            adView.TranslatesAutoresizingMaskIntoConstraints = false;

            this.Add(adView);

            NSMutableDictionary viewDictionary = new NSMutableDictionary();
            viewDictionary.Add(new NSString("ad"), adView);

            NSLayoutConstraint[] constraints = NSLayoutConstraint.FromVisualFormat("|-[ad]-|", NSLayoutFormatOptions.AlignAllBottom, null, viewDictionary);

            NSLayoutConstraint.ActivateConstraints(constraints);
        }

        UIViewController GetVisibleViewController()
        {
            var rootController = UIApplication.SharedApplication.KeyWindow.RootViewController;

            if (rootController.PresentedViewController == null)
                return rootController;

            if (rootController.PresentedViewController is UINavigationController)
            {
                return ((UINavigationController)rootController.PresentedViewController).VisibleViewController;
            }

            if (rootController.PresentedViewController is UITabBarController)
            {
                return ((UITabBarController)rootController.PresentedViewController).SelectedViewController;
            }

            return rootController.PresentedViewController;
        }
    }
}
