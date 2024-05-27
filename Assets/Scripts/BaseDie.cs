using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseDie : MonoBehaviour
{
    public DiceManager diceManager;
    public GameObject diceBody;
    public List<DiceFace> faces;
    public bool isRolling = false;
    public DiceFace currentFace;
    public Rigidbody rigidbody;
    public delegate void OnRollDelegate();
    OnRollDelegate rollToQueue;


    // Start is called before the first frame update
    public virtual void SetupDie()
    {
        diceManager = FindObjectOfType<DiceManager>();
        rigidbody = diceBody.GetComponent<Rigidbody>();

        foreach (DiceFace face in faces)
        {
            face.SetupFace();
        }
    }
    public OnRollDelegate QueueMyRoll()
    {
        rollToQueue = currentFace.OnRoll;
        return rollToQueue;
    }

    public virtual void RollDie(Vector3 throwForce)
    {
        rigidbody.AddForce(throwForce, ForceMode.Impulse);
        StartRoll();
        Debug.Log("DEPLOYING Q-BABY");
    }

    public virtual void StartRoll()
    {
        isRolling = true;
        StartCoroutine(PerformRoll());
        Debug.Log("Q-BABY DEPLOYED");
    }

    public virtual void EndRoll()
    {
        Debug.Log("I am ending my roll");
        currentFace = FindFaceupFace();
        isRolling = false;

        // Testing
        // currentFace.OnRoll();
    }

    public virtual DiceFace FindFaceupFace()
    {
        float highestFace = float.MinValue;
        int highestFaceIndex = 0;
        int count = 0;
        // -Z is facing upward. Don't ask, it makes sense to me.
        foreach (DiceFace face in faces)
        {
            if (face.transform.position.y >= highestFace)
            {
                highestFace = face.transform.position.y;
                highestFaceIndex = count;
            }
            count++;
        }

        return faces[highestFaceIndex];
    }

    IEnumerator PerformRoll()
    {
        bool currentlyRolling = true;
        Debug.Log("I have begun to roll");
        while (currentlyRolling)
        {
            Debug.Log("Still Rollin");
            yield return new WaitForSeconds(0.5f);
            if (rigidbody.velocity.sqrMagnitude == 0)
            {
                currentlyRolling = false;
                EndRoll();
                Debug.Log("Die has stopped rolling");
                yield return null;
            }
        }
    }
}