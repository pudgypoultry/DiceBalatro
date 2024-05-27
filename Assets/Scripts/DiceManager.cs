using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public List<BaseDie> managedDice;
    public List<List<int>> dieFaces = new List<List<int>>();
    public bool dieRolling = false;
    public delegate void OnRollDelegate();
    BaseDie.OnRollDelegate rollToQueue;
    List<BaseDie.OnRollDelegate> queueOfResults = new List<BaseDie.OnRollDelegate>();

    // Start is called before the first frame update
    void Start()
    {
        SetupManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (dieRolling)
        {
            bool stillGoin = CheckIfStillRolling();

            if (!stillGoin)
            {
                CollectResults();
                PerformResults();
                dieRolling = false;
            }
        }


    }

    public void SetupManager()
    {
        ResetAllDice();
    }

    public void ResetAllDice()
    {
        foreach (BaseDie die in managedDice)
        {
            die.SetupDie();
        }
    }

    public void RollDice(Vector3 throwForce)
    {
        dieRolling = true;
        foreach (BaseDie die in managedDice)
        {
            // Roll() adds force and torque from a given starting position
            Debug.Log("Rolling " + die.gameObject.name + " with force equal to " + throwForce.ToString());
            die.RollDie(throwForce + new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5)));
        }
    }

    public bool CheckIfStillRolling()
    {
        foreach (BaseDie die in managedDice)
        {
            if (die.isRolling)
            {
                return true;
            }
        }

        return false;
    }

    public void CollectResults()
    {
        foreach (BaseDie die in managedDice)
        {
            rollToQueue = die.QueueMyRoll();
            Debug.Log("Size of queue: " + queueOfResults.Count);
            queueOfResults.Add(rollToQueue);
        }
    }

    public void PerformResults()
    {
        foreach (BaseDie.OnRollDelegate result in queueOfResults)
        {
            result();
        }

        queueOfResults.Clear();
    }
}