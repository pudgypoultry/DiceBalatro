using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumericFace : DiceFace
{
    // Start is called before the first frame update
    [SerializeField]
    private int faceNumber = 1;

    public override void OnRoll(ScoreManager sm)
    {
        sm.UpdateScore(RolledNumber());
    }

    public override int RolledNumber()
    {
        return faceNumber;
    }
}
