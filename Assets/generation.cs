using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generation : MonoBehaviour
{
    public Button btn1;
    public GameObject prefab, parentobject, btn2;
    public GameObject obj1;

    delete script;

    void Start()
    {
        parentobject = GameObject.Find("Canvas");
        prefab = (GameObject)Resources.Load("Cube");
        obj1 = Instantiate(prefab) as GameObject;
        obj1.transform.SetParent(parentobject.transform, false);
        btn1 = GetComponent<Button>();
        btn2 = GameObject.Find("Button_del");
        script = btn2.GetComponent<delete>();
        // btn1.interactable = false;
    }

    public void Onclick()
    {
        btn1.interactable = true;
        obj1 = Instantiate(prefab) as GameObject;
        obj1.transform.SetParent(parentobject.transform, false);
    }
}
