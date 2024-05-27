using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierFace : DiceFace
{
    // Start is called before the first frame update
    [SerializeField]
    private int baseFaceNumber = 1;
    public int currentMultiplier;


    public override void SetupFace()
    {
        base.SetupFace();
        currentMultiplier = baseFaceNumber;
    }

    public override void OnRoll()
    {
        scoreManager.MultiplyScore(currentMultiplier);
        // Debug.Log("Result for me is " + currentFaceNumber);
    }

    public override void CheckMe()
    {
        Debug.Log(currentMultiplier);
    }
}
