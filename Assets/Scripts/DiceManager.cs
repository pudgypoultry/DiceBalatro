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
        SetupManager();
    }

    // Update is called once per frame
    void Update()
    {

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
        foreach (BaseDie die in managedDice)
        {
            // Roll() adds force and torque from a given starting position
            Debug.Log("Rolling " + die.gameObject.name + " with force equal to " + throwForce.ToString());
            die.RollDie(throwForce + new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5)));
        }

        //StartCoroutine(CheckIfDiceAreMoving());
    }

    /*
    IEnumerator CheckIfDiceAreMoving()
    {
        bool anyDieIsMoving = false;

        while (!anyDieIsMoving)
        {
            anyDieIsMoving = false;
            foreach (BaseDie die in managedDice)
            {
                Rigidbody dieRigidbody = die.rigidbody;
                if (!die.isRolling)
                {
                    anyDieIsMoving = true;
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }

        foreach (BaseDie die in managedDice)
        {
            // Roll() adds force and torque from a given starting position
            die.currentFace.OnRoll();
        }
    }
    */
}