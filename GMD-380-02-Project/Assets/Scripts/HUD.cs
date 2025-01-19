using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text HPText;
    public Text SPText;
    public Text scoreText;
    public PlayerStats playerStats;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPText.text = "HP: " + playerStats.getCurrentHP() + "/" + playerStats.getTotalHP();
        SPText.text = "SP: " + playerStats.getCurrentSP() + "/" + playerStats.getTotalSP();
        scoreText.text = "Score:" + playerStats.getScore();
    }
}
