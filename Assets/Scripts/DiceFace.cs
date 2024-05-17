using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DiceFace : MonoBehaviour
{
    [SerializeField]
    private GameObject faceImage;

    public virtual int RolledNumber()
    {
        Debug.Log("No RolledNumber() function implemented for " + this.GetType().ToString());
        return 0;
    }

    public virtual float RolledMultiplier()
    {
        Debug.Log("No RolledMultiplier() function implemented for " + this.GetType().ToString());
        return 0;
    }

    public virtual void OnRoll()
    {
        Debug.Log("No OnRoll() function implemented for " + this.GetType().ToString());
    }

    public virtual void OnRoll(ScoreManager sm)
    {
        Debug.Log("No OnRoll() function implemented for " + this.GetType().ToString());
    }

}
