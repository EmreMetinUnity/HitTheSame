using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public SoundManager sounds;
    public Image whiteeffectimage;
    private int effectcontrol = 0; //whiteeffectimage.gameObject.SetActive(false); bunu yapsaydýk effectcontrol tanýmlamamýza gerek olmazdý.
    private bool radial_Shine;
    public Image FillRateImage;
    public GameObject Player;
    public GameObject finishLine;
    public Animator layoutAnimator;

    public Text coin_text;
    public GameObject startCoin;

    //butonlar 
    public GameObject levelSelector;
    public GameObject settings_Open;
    public GameObject settings_Close;
    public GameObject layout_Background;
    public GameObject sound_Open;
    public GameObject sound_Close;
    public GameObject vibration_Open;
    public GameObject vibration_Close;
    public GameObject iap;
    public GameObject info;
    public GameObject intro_Hand;
    public GameObject taptomove_Text;
    public GameObject noAds;
    public GameObject shopButton;
    public GameObject restartScreen;

    //Oyun Sonu Ekraný
    public GameObject finishScreen;
    public GameObject blackBackground;
    public GameObject completed;
    public GameObject radialShine;
    public GameObject coin;
    public GameObject rewarded;
    public GameObject noThanks;
    public GameObject achievedCoin;
    public GameObject nextLevel;
    public Text achievedText;

    public void Start()
    {
        if (PlayerPrefs.HasKey("Sound") == false)
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        if(PlayerPrefs.HasKey("Vibration") == false)
        {   
            PlayerPrefs.SetInt("Vibration", 1);
        }

        if(PlayerPrefs.GetInt("Noads") == 1)
        {
            NoAdsRemove();
        }
        CoinTextUpdate();
    }

    public void Update()
    {
        if(radial_Shine == true)
        {
            radialShine.GetComponent<RectTransform>().Rotate(new Vector3(0,0,20f *Time.deltaTime));
        }

        FillRateImage.fillAmount = ((Player.transform.position.z -3.53f) / (finishLine.transform.position.z));
    }

    public void FirstTouchandDestroy()
    {
        intro_Hand.SetActive(false);
        taptomove_Text.SetActive(false);
        noAds.SetActive(false);
        shopButton.SetActive(false);
        settings_Open.SetActive(false);
        settings_Close.SetActive(false);
        layout_Background.SetActive(false);
        sound_Open.SetActive(false);
        sound_Close.SetActive(false);
        vibration_Open.SetActive(false);
        vibration_Close.SetActive(false);
        iap.SetActive(false);
        info.SetActive(false);
        startCoin.SetActive(false);
        levelSelector.SetActive(false);
    }

    public void NoAdsRemove()
    {
        noAds.SetActive(false);
    }

    public void CoinTextUpdate()
    {
        coin_text.text = PlayerPrefs.GetInt("moneyy").ToString();
    }

    public void RestartButtonActive()
    {
        restartScreen.SetActive(true);
    }
    
    public void RestartScene()
    {
        Variables.firstTouch = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        Variables.firstTouch = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FinishScreen()
    {
        StartCoroutine("FinishLaunch");
    }

    public IEnumerator FinishLaunch()
    {
        Time.timeScale = 0.5f;
        radial_Shine = true;
        finishScreen.SetActive(true);
        blackBackground.SetActive(true);
        yield return new WaitForSecondsRealtime(0.8f);
        completed.SetActive(true);
        sounds.CompletedSound();
        yield return new WaitForSecondsRealtime(1.4f);
        sounds.CompletedSound();
        radialShine.SetActive(true);
        coin.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        rewarded.SetActive(true);
        sounds.PurchaseSound();
        yield return new WaitForSecondsRealtime(3.5f);
        noThanks.SetActive(true);
    }

    public IEnumerator AfterRewardButton()
    {
        achievedCoin.SetActive(true);
        achievedText.gameObject.SetActive(true);
        rewarded.SetActive(false);
        noThanks.SetActive(false);
        for (int i = 0; i <= 200; i += 4)
        {
            achievedText.text = "+" + i.ToString();
            yield return new WaitForSeconds(0.001f);
        }
        yield return new WaitForSecondsRealtime(1f);
        nextLevel.SetActive(true);  
    }
    public void Privacy_Policy()
    {
        Application.OpenURL("https://www.freeprivacypolicy.com/live/b24e37cc-25c6-4186-a556-abdb088bd996");
    }
    public void Termsof_Use()
    {
        Application.OpenURL("https://termsofuse.tiiny.site/");
    }
    
    //buton fonks.
    public void Settings_Open()
    {
        settings_Open.SetActive(false);
        settings_Close.SetActive(true);
        layoutAnimator.SetTrigger("Slide_In");
        AudioListener.volume = 0;
        
        if(PlayerPrefs.GetInt("Sound") == 1)
        {
            sound_Open.SetActive(true);
            sound_Close.SetActive(false);
            AudioListener.volume = 1;
        }
        else if(PlayerPrefs.GetInt("Sound") == 2)
        {
            sound_Open.SetActive(false);
            sound_Close.SetActive(true);
            AudioListener.volume = 0;
        }

        if(PlayerPrefs.GetInt("Vibration") == 1)
        {
            vibration_Open.SetActive(true);
            vibration_Close.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("Vibration") == 2)
        {
            vibration_Open.SetActive(false);
            vibration_Close.SetActive(true);
        }
    }
    public void Settings_Close()
    {
        settings_Open.SetActive(true);
        settings_Close.SetActive(false);
        layoutAnimator.SetTrigger("Slide_Out");
    }

    public void Sound_Open()
    {
        sound_Open.SetActive(false);
        sound_Close.SetActive(true);
        AudioListener.volume = 0;
        PlayerPrefs.SetInt("Sound", 2);
    }
    public void Sound_Close()
    {
        sound_Open.SetActive(true);
        sound_Close.SetActive(false);
        AudioListener.volume = 1;
        PlayerPrefs.SetInt("Sound", 1);
    }
    public void Vibration_Open()
    {
        vibration_Open.SetActive(false);
        vibration_Close.SetActive(true);
        PlayerPrefs.SetInt("Vibration", 2);
    }
    public void Vibration_Close()
    {
        vibration_Open.SetActive(true);
        vibration_Close.SetActive(false);
        PlayerPrefs.SetInt("Vibration", 1);
    }

    //haskey
    //get     ----- playerprefs
    //set
    public IEnumerator WhiteEffect()
    {
        whiteeffectimage.gameObject.SetActive(true);
        while (effectcontrol == 0)
        {
            yield return new WaitForSeconds(0.1f);
            whiteeffectimage.color += new Color(0, 0, 0, 1f);
            if(whiteeffectimage.color == new Color(whiteeffectimage.color.r, whiteeffectimage.color.g,whiteeffectimage.color.b, 1))
            {
                effectcontrol= 1;
                //whiteeffectimage.gameObject.SetActive(false);
            }
        }

        while(effectcontrol == 1)
        {
            yield return new WaitForSeconds(0.1f);
            whiteeffectimage.color -= new Color(0, 0, 0, 1f);
            if(whiteeffectimage.color == new Color(whiteeffectimage.color.r, whiteeffectimage.color.g, whiteeffectimage.color.b, 0))
            {
                effectcontrol= 2;
            }
        }

        if(effectcontrol== 2)
        {
            Debug.Log("Efekt bitti.");
        }
    }
}
