using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseDie : MonoBehaviour
{
    public int numFaces;
    public List<int> faces;
    public TextMeshProUGUI tmpro;


    // Start is called before the first frame update
    void Awake()
    {
        tmpro = GetComponent<TextMeshProUGUI>();
        SetupDie();
    }

    public virtual void SetupDie()
    {
        for (int i = 0; i < numFaces; i++)
        {
            faces.Add(i + 1);
        }

        tmpro.text = faces[0].ToString();
    }

    public virtual int RollDie()
    {
        int whichFace = Random.Range(0, numFaces);
        tmpro.text = faces[whichFace].ToString();
        return faces[whichFace];
    }
}
