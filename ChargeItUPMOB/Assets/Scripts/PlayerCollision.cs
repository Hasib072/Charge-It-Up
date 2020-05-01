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
    
    private int[] RandomV = {-150,100,150,-100};
    private int Rv;
    private float Time = 0.6f;
   
    
    
    
    private void Awake()
    {

        
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
        
        if (other.gameObject.tag != "Floor" && other.gameObject.tag != "Chrg" && other.gameObject.tag != "Finish")
        {

            int R = Random.Range(0, 4);
            Rv = RandomV[R];
            Debug.Log(Rv);
            Debug.Log(R);

            LeanTween.moveLocalX(MCam, Rv, Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, Rv, Time).setEaseInOutBounce();
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
