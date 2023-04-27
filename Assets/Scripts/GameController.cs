using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController gc;
    public Text coinsText, lifeText;
    public int coins, lives = 3;
    // Start is called before the first frame update
    void Awake()
    {
        if(gc == null)
        {
            gc = this;
            DontDestroyOnLoad(gameObject);
        }else if (gc != this)
        {
            Destroy(gameObject);
        }
        RefreshScreen();
    }

    public void SetLives(int life)
    {
        lives += life;
        if(lives >= 0)
        {
            RefreshScreen();
        }
    }

    public void RefreshScreen()
    {
        coinsText.text = coins.ToString();
        lifeText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
