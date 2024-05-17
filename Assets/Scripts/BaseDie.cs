using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseDie : MonoBehaviour
{
    public List<DiceFace> faces;
    public TextMeshProUGUI tmpro;


    // Start is called before the first frame update
    void Awake()
    {
        tmpro = GetComponent<TextMeshProUGUI>();
    }

    public virtual void SetupDie()
    {

    }

    public virtual void RollDie()
    {

    }
}
