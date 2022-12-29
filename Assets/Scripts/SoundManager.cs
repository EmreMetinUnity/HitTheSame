using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource buttonSource;
    public AudioSource playerblowSource;
    public AudioSource purchaseSource;
    public AudioSource completedSource;
    public AudioSource objecthitSource;

    public AudioClip buttonClip;
    public AudioClip playerblowClip;
    public AudioClip purchaseClip;
    public AudioClip completedClip;
    public AudioClip objecthitClip;

    public void ButtonSound()
    {
        buttonSource.PlayOneShot(buttonClip);
    }

    public void PlayerblowSound()
    {
        buttonSource.PlayOneShot(playerblowClip,0.3f);
    }

    public void PurchaseSound()
    {
        buttonSource.PlayOneShot(purchaseClip);
    }

    public void CompletedSound()
    {
        buttonSource.PlayOneShot(completedClip);
    }

    public void ObjectHitSound()
    {
        buttonSource.PlayOneShot(objecthitClip);
    }
}
