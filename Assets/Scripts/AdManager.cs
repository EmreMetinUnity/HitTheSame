using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    private InterstitialAd interstitial;
    private RewardedAd rewardedAd;
    public UIManager uimanager;

    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-6039301851890036/6970739088";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-6039301851890036/6587595702";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    public void RequestRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-6039301851890036/5466085726";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-6039301851890036/5274514037";
#else
        string adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);


        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }

    public void ShowInterstitial()
    {
        if(PlayerPrefs.GetInt("Noads") == 0)
        {
            if (this.interstitial.IsLoaded())
            {
                this.interstitial.Show();
            }
        }
       
    }

    public void ShowRewardedAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        CoinCalculater(200);
        uimanager.StartCoroutine("AfterRewardButton");
    }

    public void CoinCalculater(int money)
    {
        if (PlayerPrefs.HasKey("moneyy"))
        {
            int oldScore = PlayerPrefs.GetInt("moneyy");
            PlayerPrefs.SetInt("moneyy", oldScore + money);
        }
        else
        {
            PlayerPrefs.SetInt("moneyy", 0);
        }
    }

    public void OnDestroy()
    {
        if(interstitial != null)
        {
            interstitial.Destroy();
        }
    }
}       
    
