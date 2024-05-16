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
        Debug.Log("Printing dieFaces: " + dieFaces.ToString());
        SetupManager();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetupManager()
    {
        for (int i = 0; i < managedDice.Count; i++)
        {
            dieFaces.Add(new List<int>());
        }

        for (int currentDie = 0; currentDie < managedDice.Count; currentDie++)
        {
            for (int currentFace = 0; currentFace < managedDice[currentDie].numFaces; currentFace++)
            {
                dieFaces[currentDie].Add(managedDice[currentDie].faces[currentFace]);
            }
        }
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
            int result = managedDice[i].RollDie();
            total += result;
            Debug.Log("Result for die " + i + " is: " + result);
        }

        return total;
    }
}
