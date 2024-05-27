using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI tmpro;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        tmpro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmpro.text = score.ToString();
    }

    public void UpdateScore(int points)
    {
        Debug.Log("Hi I'm the score manager and " + points + " is my favorite score in the galaxy");
        score += points;
    }
}
