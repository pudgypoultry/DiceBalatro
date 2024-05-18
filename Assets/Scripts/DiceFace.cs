using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DiceFace : MonoBehaviour
{
    [SerializeField]
    protected GameObject faceImage;
    protected ScoreManager scoreManager;
    protected int priority = 0;

    public virtual void SetupFace()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public virtual void OnRoll()
    {
        Debug.Log("No OnRoll() function implemented for " + this.GetType().ToString());
    }

}
