using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public UIManager uimanager;

    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;
    public GameObject particle6;
    public GameObject particle7;
    public GameObject particle8;
    public GameObject particle9;
    public GameObject particle10;
    public GameObject particle11;
    public GameObject particle12;
    
    public Sprite YellowImage;
    public Sprite GreenImage;

    public GameObject Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10, Item11, Item12;

    public GameObject Lock2, Lock3, Lock4, Lock5, Lock6, Lock7, Lock8, Lock9, Lock10, Lock11, Lock12;

    public void Awake()
    {
        if (PlayerPrefs.HasKey("itemselect") == false)
        {
            PlayerPrefs.SetInt("itemselect", 0);
        }

        //ITEMSELECT***

        if(PlayerPrefs.GetInt("itemselect") == 0)
        {
            Item1Open();
        }
        else if(PlayerPrefs.GetInt("itemselect") == 1)
        {
            Item2Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 2)
        {
            Item3Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 3)
        {
            Item4Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 4)
        {
            Item5Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 5)
        {
            Item6Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 6)
        {
            Item7Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 7)
        {
            Item8Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 8)
        {
            Item9Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 9)
        {
            Item10Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 10)
        {
            Item11Open();
        }
        else if (PlayerPrefs.GetInt("itemselect") == 11)
        {
            Item12Open();
        }




        //LOCKS***
        if (PlayerPrefs.HasKey("Lock2Control") == false)
        {
            PlayerPrefs.SetInt("Lock2Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock3Control") == false)
        {
            PlayerPrefs.SetInt("Lock3Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock4Control") == false)
        {
            PlayerPrefs.SetInt("Lock4Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock5Control") == false)
        {
            PlayerPrefs.SetInt("Lock5Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock6Control") == false)
        {
            PlayerPrefs.SetInt("Lock6Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock7Control") == false)
        {
            PlayerPrefs.SetInt("Lock7Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock8Control") == false)
        {
            PlayerPrefs.SetInt("Lock8Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock9Control") == false)
        {
            PlayerPrefs.SetInt("Lock9Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock10Control") == false)
        {
            PlayerPrefs.SetInt("Lock10Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock11Control") == false)
        {
            PlayerPrefs.SetInt("Lock11Control", 0);
        }

        if (PlayerPrefs.HasKey("Lock12Control") == false)
        {
            PlayerPrefs.SetInt("Lock12Control", 0);
        }

        if(PlayerPrefs.GetInt("Lock2Control") == 1)
        {
            Lock2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock3Control") == 1)
        {
            Lock3.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock4Control") == 1)
        {
            Lock4.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock5Control") == 1)
        {
            Lock5.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock6Control") == 1)
        {
            Lock6.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock7Control") == 1)
        {
            Lock7.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock8Control") == 1)
        {
            Lock8.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock9Control") == 1)
        {
            Lock9.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock10Control") == 1)
        {
            Lock10.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock11Control") == 1)
        {
            Lock11.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Lock12Control") == 1)
        {
            Lock12.SetActive(false);
        }
    }

    public void Item1Open()
    {
        particle1.SetActive(true);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = GreenImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 0);
    }

    public void Item2Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(true);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = GreenImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 1);

    }

    public void Item3Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(true);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = GreenImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 2);
    }

    public void Item4Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(true);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = GreenImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 3);
    }

    public void Item5Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(true);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = GreenImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 4);
    }

    public void Item6Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(true);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = GreenImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 5);
    }

    public void Item7Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(true);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = GreenImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 6);
    }

    public void Item8Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(true);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = GreenImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 7);
    }

    public void Item9Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(true);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = GreenImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 8);
    }

    public void Item10Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(true);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = GreenImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 9);
    }

    public void Item11Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(true);
        particle8.SetActive(false);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = GreenImage;
        Item12.GetComponent<Image>().sprite = YellowImage;

        PlayerPrefs.SetInt("itemselect", 10);
    }

    public void Item12Open()
    {
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        particle7.SetActive(false);
        particle8.SetActive(true);
        particle9.SetActive(false);
        particle10.SetActive(false);
        particle11.SetActive(false);
        particle12.SetActive(false);

        Item1.GetComponent<Image>().sprite = YellowImage;
        Item2.GetComponent<Image>().sprite = YellowImage;
        Item3.GetComponent<Image>().sprite = YellowImage;
        Item4.GetComponent<Image>().sprite = YellowImage;
        Item5.GetComponent<Image>().sprite = YellowImage;
        Item6.GetComponent<Image>().sprite = YellowImage;
        Item7.GetComponent<Image>().sprite = YellowImage;
        Item8.GetComponent<Image>().sprite = YellowImage;
        Item9.GetComponent<Image>().sprite = YellowImage;
        Item10.GetComponent<Image>().sprite = YellowImage;
        Item11.GetComponent<Image>().sprite = YellowImage;
        Item12.GetComponent<Image>().sprite = GreenImage;

        PlayerPrefs.SetInt("itemselect", 11);
    }

    //Locks

    public void Lock2Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock2control = PlayerPrefs.GetInt("Lock2Control");
        if(money >= 2000 && lock2control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 2000);
            PlayerPrefs.SetInt("Lock2Control", 1);
            Item2Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock3Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock3control = PlayerPrefs.GetInt("Lock3Control");
        if (money >= 4000 && lock3control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 4000);
            PlayerPrefs.SetInt("Lock3Control", 1);
            Item3Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock4Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock4control = PlayerPrefs.GetInt("Lock4Control");
        if (money >= 6000 && lock4control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 6000);
            PlayerPrefs.SetInt("Lock4Control", 1);
            Item4Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock5Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock5control = PlayerPrefs.GetInt("Lock5Control");
        if (money >= 7000 && lock5control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 7000);
            PlayerPrefs.SetInt("Lock5Control", 1);
            Item5Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock6Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock6control = PlayerPrefs.GetInt("Lock6Control");
        if (money >= 7000 && lock6control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 7000);
            PlayerPrefs.SetInt("Lock6Control", 1);
            Item6Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock7Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock7control = PlayerPrefs.GetInt("Lock7Control");
        if (money >= 8000 && lock7control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 8000);
            PlayerPrefs.SetInt("Lock7Control", 1);
            Item7Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock8Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock8control = PlayerPrefs.GetInt("Lock8Control");
        if (money >= 8000 && lock8control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 8000);
            PlayerPrefs.SetInt("Lock8Control", 1);
            Item8Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock9Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock9control = PlayerPrefs.GetInt("Lock9Control");
        if (money >= 14000 && lock9control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 14000);
            PlayerPrefs.SetInt("Lock9Control", 1);
            Item9Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock10Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock10control = PlayerPrefs.GetInt("Lock10Control");
        if (money >= 14000 && lock10control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 14000);
            PlayerPrefs.SetInt("Lock10Control", 1);
            Item10Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock11Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock11control = PlayerPrefs.GetInt("Lock11Control");
        if (money >= 20000 && lock11control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 20000);
            PlayerPrefs.SetInt("Lock11Control", 1);
            Item11Open();
            uimanager.CoinTextUpdate();
        }
    }

    public void Lock12Open()
    {
        int money = PlayerPrefs.GetInt("moneyy");
        int lock12control = PlayerPrefs.GetInt("Lock12Control");
        if (money >= 20000 && lock12control == 0)
        {
            Lock2.SetActive(false);
            PlayerPrefs.SetInt("moneyy", money - 20000);
            PlayerPrefs.SetInt("Lock12Control", 1);
            Item12Open();
            uimanager.CoinTextUpdate();
        }
    }

}
