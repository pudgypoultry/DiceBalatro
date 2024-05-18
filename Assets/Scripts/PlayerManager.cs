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
        dm.RollDice(new Vector3(-5, 5, -7));
        Debug.Log("Tossing Dice");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
