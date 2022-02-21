using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateScore : MonoBehaviour
{

    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText= GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text= Score.scoreValue.ToString();
        if(Score.scoreValue >= 10)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
