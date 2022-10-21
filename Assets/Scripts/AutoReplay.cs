using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public TextMeshProUGUI info;
    void Start()
    {
        if (EnemyController.EnemyKilled == 3)
        {
            info.text = "Congratulations \n You Win!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            EnemyController.EnemyKilled = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
