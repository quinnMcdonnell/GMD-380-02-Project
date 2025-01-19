using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float totalHP = 100;
    [SerializeField] float currentHP;
    [SerializeField] float totalSP = 50;
    [SerializeField] float currentSP;

    [SerializeField] float baseScoreAddition;
    [SerializeField] float baseScoreMultiplier;
    public float score = 0;

    private void Awake()
    {
        currentHP = totalHP;
        currentSP = totalSP;
    }

    //HP & SP Getters
    public float getTotalHP() { return totalHP; }
    public float getCurrentHP() { return currentHP; }
    public float getTotalSP() { return totalSP; }
    public float getCurrentSP() { return currentSP; }

    //HP & SP Setters
    public void setTotalHP(float value) { totalHP = value; }
    
    public void setCurrentHP(float value) { currentHP = value; }

    public void setTotalSP(float value) { totalSP = value; }
    
    public void setCurrentSP(float value) { currentSP = value; }


    public float getBaseScoreAddition() { return baseScoreAddition; }
    public float getBaseScoreMultiplier() { return baseScoreMultiplier; }
    public float getScore() { return score; } 

    public void setBaseScoreAddition(float value) { baseScoreAddition = value; }
    public void setBaseScoreMultiplier(float value) { baseScoreMultiplier = value; }
    public void setScore(float value) { score = value; }
}
