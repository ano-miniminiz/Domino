using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject triggerobject;

    void Start()
    {
        triggerobject = GameObject.Find("Cube");
    }

    public void Onclick()
    {
        triggerobject.transform.Rotate(15, 0, 0, Space.Self);
    }
}
