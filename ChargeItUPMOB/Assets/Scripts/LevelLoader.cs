using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator trans;
    public float time;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && Input.GetButtonDown("Fire3"))
        {
            NextLevel();
        }

    }


    

    public void LoadMenu1()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 1));
        Time.timeScale = 1f;

    }

    public void LoadMenu2()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex -2));
        Time.timeScale = 1f;

    }

    public void LoadMenu3()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 3));
        Time.timeScale = 1f;

    }

    public void LoadMenu4()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 4));
        Time.timeScale = 1f;

    }

    public void LoadMenu5()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 5));
        Time.timeScale = 1f;

    }

    public void LoadMenu6()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 6));
        Time.timeScale = 1f;

    }

    public void LoadMenu7()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 7));
        Time.timeScale = 1f;

    }

    public void LoadMenu8()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 8));
        Time.timeScale = 1f;
        
    }

    public void LoadMenu9()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 8));
        Time.timeScale = 1f;

    }

    public void LoadMenu10()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 10));
        Time.timeScale = 1f;

    }

    public void NextLevel() 
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void RestartLV()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex));
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    IEnumerator NextLevel(int LevelIndex)
    {
        trans.SetTrigger("Start");

        yield return new WaitForSeconds(time);
        
        SceneManager.LoadScene(LevelIndex);

        
    }

    
}
