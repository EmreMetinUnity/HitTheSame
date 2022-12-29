using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uimanager;
    public AdManager adManager;
    public void Start()
    {
        CoinCalculater(0);
        Debug.Log(PlayerPrefs.GetInt("moneyy"));
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && gameObject.CompareTag("FinishLine"))
        {
            Debug.Log("Oyun Bitti.");
            if(PlayerPrefs.GetInt("Noads") == 0)
            {
                adManager.RequestInterstitial();
            }
            adManager.RequestRewardedAd();
            CoinCalculater(100);
            uimanager.CoinTextUpdate();
            uimanager.FinishScreen();
            PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);
        }
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
}
