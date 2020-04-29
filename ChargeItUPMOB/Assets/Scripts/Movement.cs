using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Movement : MonoBehaviour
{
    //[SerializeField]
    private GameObject PlayerBody;
    private Rigidbody Player;
    public float Speed;
    public int Charge;
    private Vector3 Newmove;
    private bool MoveW, MW, MoveS, MS, MoveA, MA, MoveD, MD, IsStop;
    private GameObject MCam;
    private AudioSource Hit;
    private float x, x2;    
    private float Time = 0.6f;


    void Awake()
    {
        
        MoveW = MoveS = MoveA = MoveD = IsStop = false;

        x2 = 50;
        x = -(x2);
        

        PlayerBody = GameObject.Find("Billy");
        Player = PlayerBody.GetComponent<Rigidbody>();
        Hit = PlayerBody.GetComponent<AudioSource>();

        MCam = GameObject.Find("CamJ");


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Floor")
        {

            LeanTween.moveLocalX(MCam, Random.Range(x, x2), Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, Random.Range(x, x2), Time).setEaseInOutBounce();
            Charge = Charge - 1;
            LeanTween.moveLocalX(MCam, 0, Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, 0, Time).setEaseInOutBounce();
            Hit.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chrg"))
        {
            other.gameObject.SetActive(false);
            Charge = Charge + 2;
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            print("End");
        }
    }


    void FixedUpdate()
    {


        print(MA);
        print(Player.velocity);
        

        if (Player.velocity.x == 0f && Player.velocity.z == 0f)
        {
            IsStop = true;

           
        }
        else if (Player.velocity.x == Random.Range(-50,50) && Player.velocity.z == Random.Range(-50, 50))
        {
            NOMove();
        }
        else
        {
            IsStop = false;

            NOMove();
        }

        if (IsStop == true)
        {
            
            if (Input.GetKey("a") || MA == true)
            {
                MoveA = true;
                
            }
            else
            {
                MoveA = false;
            }
            if (Input.GetKey("d") || MD == true)
            {
                MoveD = true;
               
            }
            else
            {
                MoveD = false;
            }
            if (Input.GetKey("w") || MW == true)
            {
                MoveW = true;
               
            }
            else
            {
                MoveW = false;
            }
            if (Input.GetKey("s") || MS == true)
            {
                MoveS = true;
                
            }
            else
            {
                MoveS = false;
            }

        }


        if (IsStop == true)
        {
            if (MoveA == true)
            {
                Newmove = new Vector3(-(Speed), Player.velocity.y, 0);
                Player.velocity = Newmove;
                Player.transform.LookAt(Player.transform.position + new Vector3(Newmove.z, 0, Newmove.x));
                
            }
            if (MoveD == true)
            {
                Newmove = new Vector3((Speed), Player.velocity.y, 0);
                Player.velocity = Newmove;
                Player.transform.LookAt(Player.transform.position + new Vector3(Newmove.z, 0, Newmove.x));
                

            }
            if (MoveS == true)
            {
                Newmove = new Vector3(0, Player.velocity.y, -(Speed));
                Player.velocity = Newmove;
                Player.transform.LookAt(Player.transform.position + new Vector3(-Newmove.z, 0, -Newmove.x));
                
            }
            if (MoveW == true)
            {
                Newmove = new Vector3(0, Player.velocity.y, Speed);
                Player.velocity = Newmove;
                Player.transform.LookAt(Player.transform.position + new Vector3(-Newmove.z, 0, -Newmove.x));
                
            }
        }

        

    }

    

    public void MoveForward()
    {
        MW = true;
        

    }

    public void MoveBackward()
    {
        MS = true;
       
    }

    public void MoveRight()
    {
        MD = true;
        
    }

    public void MoveLeft()
    {
        MA = true;
        
    }

    public void NOMove()
    {

        MW = false;
        MS = false;
        MA = false;
        MD = false;

    }
    


}
