using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public DiceManager dm;
    public ScoreManager sm;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int pointsScored = dm.RollAllDice();
            sm.UpdateScore(pointsScored);
        }
    }
}
