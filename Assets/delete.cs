using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delete : MonoBehaviour
{
    public Button btn2;
    GameObject btn1;
    generation script;

    void Start()
    {
        btn1 = GameObject.Find("Button_gene");
        script = btn1.GetComponent<generation>();
    }

    public void OnClick()
    {
        // btn2.interactable = false;
        Destroy(script.obj1);
        script.btn1.interactable = true;
    }
}
