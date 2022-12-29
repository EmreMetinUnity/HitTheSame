using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public CameraShake cameraShake;
    public UIManager uimanager;
    public SoundManager sounds;

    public GameObject cam;
    public CameraMove camMove;
    public GameObject vectorback;
    public GameObject vectorforward;

    private Rigidbody rb; 
    private Touch touch;
    public int speedModifier = 20;
    public float forwardSpeed;
    private bool speedballForward = false;
    private bool firstTouchControl = false;

    private int soundlimitCount;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if(Variables.firstTouch == 1 && speedballForward == false)
        {
            transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            vectorback.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
            vectorforward.transform.position += new Vector3(0, 0, forwardSpeed * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);


            if(touch.phase == TouchPhase.Began)
            {
                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    if(firstTouchControl == false)
                    {
                        Variables.firstTouch = 1;
                        uimanager.FirstTouchandDestroy();
                        firstTouchControl = true;
                    }
                    
                }
               
            }
            else if(touch.phase == TouchPhase.Moved)
            {
                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    rb.velocity = new Vector3(touch.deltaPosition.x * speedModifier * Time.deltaTime, transform.position.y,
                                            touch.deltaPosition.y * speedModifier * Time.deltaTime);
                    if(transform.position.y >= 1)
                    {
                        rb.velocity = new Vector3(touch.deltaPosition.x * speedModifier * Time.deltaTime, 0, 0);
                    }
                    
                    if (firstTouchControl == false)
                    {
                        Variables.firstTouch = 1;
                        uimanager.FirstTouchandDestroy();
                        firstTouchControl = true;
                    }

                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector3.zero;
            }
        }
        
    }

    public GameObject[] FractureItems;

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Obstacles"))
        {
            cameraShake.CameraShakesCall();
            uimanager.StartCoroutine("WhiteEffect");
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            sounds.PlayerblowSound();
            if(PlayerPrefs.GetInt("Vibration") == 1)
            {
                Vibration.Vibrate(75);
            }
            else
            {
                Debug.Log("no vibration.");
            }
            Debug.Log("Çarpýldý.");
            foreach (GameObject item in FractureItems)
            {
                item.GetComponent<SphereCollider>().enabled = true;
                item.GetComponent<Rigidbody>().isKinematic = false;
            }
            StartCoroutine("TimeScaleControl");
        }

        if (hit.gameObject.CompareTag("Untagged"))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
            soundlimitCount++;
        }
        if (hit.gameObject.CompareTag("Untagged") && soundlimitCount % 2 == 0)
        {
            sounds.ObjectHitSound();
        }
        else if (hit.gameObject.CompareTag("Lever"))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            sounds.ObjectHitSound();
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishLine"))
        {
            forwardSpeed = 0.8f;
            camMove.CamForwardSpeed();
        }
    }
    public IEnumerator TimeScaleControl()
    {
        speedballForward = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 0.3f;
        yield return new WaitForSecondsRealtime(0.3f);
        uimanager.RestartButtonActive();
        rb.velocity = Vector3.zero;
    }   
}
