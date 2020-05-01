using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComP : MonoBehaviour
{

    private GameObject Exit;
    private GameObject LLScript;
    public LevelLoader LL;
    public GameObject OverScr;
    
    void Awake()
    {
        Exit = GameObject.Find("Exit");
        LLScript = GameObject.Find("FadeObj");
        LL = LLScript.GetComponent<LevelLoader>();
        OverScr = GameObject.Find("UI");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LL.NextLevel();
            Destroy(OverScr);
        }
    }


    void Update()
    {
        
    }
}
