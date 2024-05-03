using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public Text scoreTextEnd;
    int score;
    public GameObject panelUlangi;
    public GameObject panelFinish;
    public GameObject panelPause;
    public GameObject panelCoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        scoreTextEnd.text = "Coins Obtain: " + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            score++;
            GameObject.Find("coin-04").GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }
        
        if(collision.CompareTag("Obstacle"))
        {
            panelUlangi.SetActive (true);
            Time.timeScale = 0;
            GameObject.Find("deathEffect").GetComponent<AudioSource>().Play();
        }

        if(collision.CompareTag("FinishTag"))
        {
            panelFinish.SetActive (true);
            Time.timeScale = 0;
            panelPause.SetActive (false);
            panelCoin.SetActive (false);
            GameObject.Find("Complate").GetComponent<AudioSource>().Play();
        }
    }
}
