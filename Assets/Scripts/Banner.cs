using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Banner : MonoBehaviour
{
    private BannerView bannerView;

    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        if (PlayerPrefs.HasKey("Noads") == false)
        {
            PlayerPrefs.SetInt("Noads", 0);
        }

        if (PlayerPrefs.GetInt("Noads") == 0)
        {
            this.RequestBanner();
        }
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-6039301851890036/4705907512";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-6039301851890036/7900677378";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }
}
