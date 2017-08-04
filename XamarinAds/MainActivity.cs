using System;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;

namespace XamarinAds{
    [Activity(Label = "XamarinAds", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity{

        protected AdView mAdView;
        protected InterstitialAd mInterstitialAd;
        protected Button mLoadInterstitialButton;

        protected override void OnCreate(Bundle bundle){
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            //-------------------------------
            var appid = "ca-app-pub-1511238554569737~3292095533"; //Id do APP
            MobileAds.Initialize(ApplicationContext, appid);

            var adview = FindViewById<AdView>(Resource.Id.adView);
            var adrequest = new AdRequest.Builder().Build();
            adview.LoadAd(adrequest);
            


        }
    }
}

