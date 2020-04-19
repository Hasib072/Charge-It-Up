using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{

    public Text Life;
    public NewMove2 Pl;
   
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        Life.text = Pl.Charge.ToString();
    }
}
