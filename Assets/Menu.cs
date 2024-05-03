using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject panelPlayList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playList()
    {
        panelPlayList.SetActive(true);
    }
    public void closePlayList()
    {
        panelPlayList.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
    public void Play2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
    public void Play3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }
    public void Hint()
    {
        SceneManager.LoadScene("Hint");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
