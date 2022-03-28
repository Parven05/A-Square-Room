using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    private 
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    
    }

    void Update()
    {
     if (score >= 250)
        {
            YouWin();
        }  
    }
    void YouWin()
    {
        text.text = "You Win !";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}

