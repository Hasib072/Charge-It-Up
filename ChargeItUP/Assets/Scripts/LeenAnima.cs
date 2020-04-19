using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenAnima : MonoBehaviour
{
    public GameObject Cell1;
    public GameObject Cell2;
    public GameObject Cell3;
    public GameObject Cell4;
    public GameObject Cell5;
    public float t;
    public float y;
    
    void Start()
    {
        Cell1 = GameObject.Find("Cell1");
        Cell2 = GameObject.Find("Cell2");
        Cell3 = GameObject.Find("Cell3");
        Cell4 = GameObject.Find("Cell4");
        Cell5 = GameObject.Find("Cell5");




        LeanTween.rotateY(Cell1, y, t).setLoopPingPong();
        LeanTween.rotateY(Cell2, y, t).setLoopPingPong();
        LeanTween.rotateY(Cell3, y, t).setLoopPingPong();
        LeanTween.rotateY(Cell4, y, t).setLoopPingPong();
        LeanTween.rotateY(Cell5, y, t).setLoopPingPong();

    }

    
    void Update()
    {
        
    }
}
