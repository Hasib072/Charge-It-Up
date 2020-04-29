using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameObject PlayerBody;
    private GameObject PowerUpObj;
    private AudioSource PowerUp;
    public int Charge;
    private AudioSource Hit;
    private GameObject MCam;
    private float x, x2;
    private float Time = 0.6f;
   
    
    
    
    private void Awake()
    {

        x2 = Random.Range(-1,1)*100;
        x = Random.Range(-1,1)*100;
        PowerUpObj = GameObject.Find("Powerup");
        PowerUp = PowerUpObj.GetComponent<AudioSource>();
        PlayerBody = GameObject.Find("Billy");
        MCam = GameObject.Find("CamJ");
        Hit = PlayerBody.GetComponent<AudioSource>();
    }
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chrg"))
        {
            other.gameObject.SetActive(false);
            Charge = Charge + 2;
            PowerUp.Play();
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            print("End");
        }
        if (other.gameObject.tag != "Floor" && other.gameObject.tag != "Chrg" && other.gameObject.tag != "Finish")
        {
            
            LeanTween.moveLocalX(MCam, x, Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, x2, Time).setEaseInOutBounce();
            Charge = Charge - 1;
            LeanTween.moveLocalX(MCam, 0, Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, 0, Time).setEaseInOutBounce();
            Hit.Play();
        }
    }

    void Update()
    {
        
    }
}
