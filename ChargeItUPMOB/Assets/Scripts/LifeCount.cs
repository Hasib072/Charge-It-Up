using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{

    private GameObject PlayerBody;
    private Rigidbody Player;
    private GameObject OverScr;
    private GameObject PrvScr;
    public Text Life;
    private GameObject PlayerColl;
    private PlayerCollision Pl;
   
    
    void Awake()
    {
        PlayerColl = GameObject.Find("BColl");
        Pl = PlayerColl.GetComponent<PlayerCollision>();

        PlayerBody = GameObject.Find("Billy");
        Player = PlayerBody.GetComponent<Rigidbody>();

        OverScr = GameObject.Find("GameOverScr");
        PrvScr = GameObject.Find("MUI");

        OverScr.SetActive(false);
    }

    
    void Update()
    {
        if (Pl.Charge < 0)
        {
            print("Game over");
            OverScr.SetActive(true);
            Player.Sleep();
            PrvScr.SetActive(false);
        }
        Life.text = Pl.Charge.ToString();
    }
}
