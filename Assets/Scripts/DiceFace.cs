using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FaceType
{
    MULTIPLIER,
    NUMERIC,
    PASSFAIL,
    SPECIAL
}

public abstract class DiceFace : MonoBehaviour
{
    [SerializeField]
    protected GameObject faceImage;
    protected ScoreManager scoreManager;
    public int priority = 0;
    public FaceType faceType;

    protected void Start()
    {
        SetupFace();
    }

    public virtual void SetupFace()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public virtual void OnRoll()
    {
        Debug.Log("No OnRoll() function implemented for " + this.GetType().ToString());
    }

    public virtual void CheckMe()
    {
        Debug.Log("No CheckMe() function implemented for " + this.GetType().ToString());
    }
}
