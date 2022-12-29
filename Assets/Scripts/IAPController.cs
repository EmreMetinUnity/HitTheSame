using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using Unity.Services.Core;
using UnityEngine.Purchasing;


namespace Unity.Services.Core
{
    public static class UnityServices { }

}
public class IAPController : MonoBehaviour,IStoreListener
{
    public UIManager uimanager;
    public SoundManager sounds;
    IStoreController controller;

    public string[] product;

    public void Start()
    {
        IAPStart();
    }

    public void IAPStart()
    {
        var module = StandardPurchasingModule.Instance();
        ConfigurationBuilder builder = ConfigurationBuilder.Instance(module);

        foreach (string item in product)
        {
            builder.AddProduct(item, ProductType.Consumable);
        }

        UnityPurchasing.Initialize(this, builder);
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        this.controller = controller;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("Failed initiliaze.");
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log("Purchase Failed.");
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
    {
        if (string.Equals(e.purchasedProduct.definition.id, product[0],StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 2500);
            uimanager.CoinTextUpdate();
            sounds.PurchaseSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[1], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 8000);
            uimanager.CoinTextUpdate();
            sounds.PurchaseSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[2], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 15000);
            uimanager.CoinTextUpdate();
            sounds.PurchaseSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[3], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 30000);
            uimanager.CoinTextUpdate();
            sounds.PurchaseSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[4], StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("moneyy", PlayerPrefs.GetInt("moneyy") + 150000);
            uimanager.CoinTextUpdate();
            sounds.PurchaseSound();
            return PurchaseProcessingResult.Complete;
        }
        else if (string.Equals(e.purchasedProduct.definition.id, product[5], StringComparison.Ordinal))
        {
            if (PlayerPrefs.HasKey("Noads") == true)
            {
                PlayerPrefs.SetInt("Noads", 1);
                uimanager.NoAdsRemove();
                sounds.PurchaseSound();
            }
            return PurchaseProcessingResult.Complete;
        }
        else
        {
            return PurchaseProcessingResult.Pending;
        }
    }

    public void IAPButton(string id)
    {
        Product product = controller.products.WithID(id);
        if (product != null && product.availableToPurchase)
        {
            controller.InitiatePurchase(product);
            Debug.Log("Buying.");
        }
        else
        {
            Debug.Log("Buying Failed.");
        }
    }
}
