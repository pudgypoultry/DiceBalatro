using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumericFace : DiceFace
{
    // Start is called before the first frame update
    [SerializeField]
    private int baseFaceNumber = 1;
    public int currentFaceNumber;


    public override void SetupFace()
    {
        base.SetupFace();
        currentFaceNumber = baseFaceNumber;
    }

    public override void OnRoll()
    {
        scoreManager.UpdateScore(currentFaceNumber);
        // Debug.Log("Result for me is " + currentFaceNumber);
    }

    public override void CheckMe()
    {
        Debug.Log(currentFaceNumber);
    }

    public void ApplyMultiplier(float multiplier)
    {
        currentFaceNumber = Mathf.RoundToInt(currentFaceNumber * multiplier);
    }
}
