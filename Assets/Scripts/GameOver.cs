using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI txScore;
    public TextMeshProUGUI txHighScore;
    TextMeshProUGUI txSelamat;
    int highscore;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("HS", 0);
        if (Data.score > highscore)
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("HS", highscore);
        }
        else if (EnemyController.EnemyKilled == 3)
        {
            SceneManager.LoadScene("Congratulations");
        }
        txHighScore.text = "HighScore: " + highscore;
        txScore.text = "score: " + Data.score;
    }
    public void Replay()
    {
        Data.score = 0;
        EnemyController.EnemyKilled = 0;
        SceneManager.LoadScene("Gameplay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
