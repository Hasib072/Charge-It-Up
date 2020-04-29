using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{

    public Text Life;
    private GameObject Player;
    private Movement Pl;
   
    
    void Awake()
    {
        Player = GameObject.Find("Billy");
        Pl = Player.GetComponent<Movement>();
    }

    
    void Update()
    {
        
        Life.text = Pl.Charge.ToString();
    }
}
