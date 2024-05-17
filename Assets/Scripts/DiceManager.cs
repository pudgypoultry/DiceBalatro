using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public List<BaseDie> managedDice;
    public List<List<int>> dieFaces = new List<List<int>>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetupManager()
    {

    }

    public void ResetAllDice()
    {
        foreach (BaseDie die in managedDice)
        {
            die.SetupDie();
        }
    }

    public int RollAllDice()
    {
        int total = 0;

        for (int i = 0; i < managedDice.Count; i++)
        {
            // Throw dice
            // Outside of the loop, we need to wait to land, grab face up guys, then call their functions
        }

        return total;
    }
}
