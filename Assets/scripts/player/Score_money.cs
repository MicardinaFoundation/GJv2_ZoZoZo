using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_money : MonoBehaviour
{
    public Text MonScore;
    public static int money_scores;
    // Start is called before the first frame update
    void Start()
    {
        money_scores = 2500;
    }

    // Update is called once per frame
    void Update()
    {
        MonScore.text = money_scores.ToString();
    }
}
