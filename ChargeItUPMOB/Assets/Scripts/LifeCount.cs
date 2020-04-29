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
    private GameObject Exit;
    private LevelLoader LevelLoader;

    void Awake()
    {
        PlayerColl = GameObject.Find("BColl");
        Pl = PlayerColl.GetComponent<PlayerCollision>();

        PlayerBody = GameObject.Find("Billy");
        Player = PlayerBody.GetComponent<Rigidbody>();

        OverScr = GameObject.Find("GameOverScr");
        PrvScr = GameObject.Find("MUI");

        Exit = GameObject.Find("Exit");
        LevelLoader = Exit.GetComponent<LevelLoader>();

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
            LevelLoader.Pause();
        }
        Life.text = Pl.Charge.ToString();
    }
}
