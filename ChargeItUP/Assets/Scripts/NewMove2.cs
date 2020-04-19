﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove2 : MonoBehaviour
{
    public Rigidbody player;
    public AudioSource Hit;
    public float Speed;
    private Vector3 Newmove;
    public int Charge;
    private bool MoveF;
    private bool MoveB;
    private bool MoveR;
    private bool MoveL;
    private bool PStopx;
    private bool PStopz;
    private bool PStop;
    public GameObject MCam;
    public float x;
    public float x2;
    public float y;
    public float y2;
    public float Time;
    public LevelLoader LL2;
    public GameObject OverScr;
    public GameObject PrvScr;
    public GameObject Cell1;
    
    public GameObject Cell2;
    
    public GameObject Cell3;
    
    public GameObject Cell4;
    
    public GameObject Cell5;
    public AudioSource CP5;




    private void Awake()
    {
        //Time2 = Time + 0.5f;
        Cell1 = GameObject.Find("Cell1");
        Cell2 = GameObject.Find("Cell2");
        Cell3 = GameObject.Find("Cell3");
        Cell4 = GameObject.Find("Cell4");
        Cell5 = GameObject.Find("Cell5");

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Floor")
        {

            LeanTween.moveLocalX(MCam, Random.Range(x,x2), Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, Random.Range(y, y2), Time).setEaseInOutBounce();
            print("it Works");
            LeanTween.moveLocalX(MCam, 0, Time).setEaseInOutBounce();
            LeanTween.moveLocalZ(MCam, 0, Time).setEaseInOutBounce();
            Hit.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cell1")
        {
            Charge = Charge + 2;
            Destroy(Cell1);
            CP5.Play();
            
        }
        if (other.name == "Cell2")
        {
            Charge = Charge + 2;
            Destroy(Cell2);
            CP5.Play();
        }
        if (other.name == "Cell3")
        {
            Charge = Charge + 2;
            Destroy(Cell3);
            CP5.Play();
        }
        if (other.name == "Cell4")
        {
            Charge = Charge + 2;
            Destroy(Cell4);
            CP5.Play();
        }
        if (other.name == "Cell5")
        {
            Charge = Charge + 2;
            Destroy(Cell5);
            CP5.Play();
        }

        if (other.tag == "Finish")
        {
            LL2.NextLevel();
            print("The End");
        }
    }




    void FixedUpdate()
    {

        

        if (player.velocity.x < 60 && player.velocity.x > -60)
        {
            PStopx = true;
        }
        else
        {
            PStopx = false;
        }
       
        if (player.velocity.z < 60 && player.velocity.z > -(60))
        {
            PStopz = true;
        }
        else
        {
            PStopz = false;
        }

        if (PStopx == true && PStopz == true)
        {
            PStop = true;
        }
        else
        {
            PStop = false;
        }



        print(PStop);

        if (PStopx == true && Input.GetKeyDown("s"))
        {
            MoveF = true;
            Charge = Charge - 1;
           
        }
        else
        {
            MoveF = false;
        }


        if (PStop == true && Input.GetKeyDown("w"))
        {
            MoveB = true;
            Charge = Charge - 1;
            
        }
        else
        {
            MoveB = false;
        }

        if (PStop == true && Input.GetKeyDown("d"))
        {
            MoveR = true;
            Charge = Charge - 1;
            
        }
        else
        {
            MoveR = false;
        }


        if (PStop == true && Input.GetKeyDown("a"))
        {
            MoveL = true;
            Charge = Charge - 1;
            
        }
        else
        {
            MoveL = false;
        }



        if (MoveF == true)
        {
            Newmove = new Vector3(Speed, player.velocity.y, 0);
            player.velocity = Newmove;
            player.transform.LookAt(player.transform.position + new Vector3(Newmove.z, 0, Newmove.x));

        }

        if (MoveB == true)
        {
            Newmove = new Vector3(-Speed, player.velocity.y, 0);
            player.velocity = Newmove;
            player.transform.LookAt(player.transform.position + new Vector3(Newmove.z, 0, Newmove.x));
        }

        if (MoveR == true)
        {
            Newmove = new Vector3(0, player.velocity.y, Speed);
            player.velocity = Newmove;
            player.transform.LookAt(player.transform.position + new Vector3(-Newmove.z, 0, -Newmove.x));
        }

        if (MoveL == true)
        {
            Newmove = new Vector3(0, player.velocity.y, -Speed);
            player.velocity = Newmove;
            player.transform.LookAt(player.transform.position + new Vector3(-Newmove.z, 0, -Newmove.x));
        }

        
        if (Charge < 0)
        {
            print("Game over");
            OverScr.SetActive(true);
            player.Sleep();
            PrvScr.SetActive(false);
        }


    }
    public void MoveForward()
    {
        MoveF = true;


    }

    public void MoveBackward()
    {
        MoveB = true;

    }

    public void MoveRight()
    {
        MoveR = true;

    }

    public void MoveLeft()
    {
        MoveL = true;

    }

    public void NOMoveForward()
    {
        MoveF = false;


    }

    public void NOMoveBackward()
    {
        MoveB = false;

    }

    public void NOMoveRight()
    {
        MoveR = false;

    }

    public void NOMoveLeft()
    {
        MoveL = false;

    }


}
