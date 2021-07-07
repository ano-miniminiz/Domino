using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generation : MonoBehaviour
{
    public Button btn1;
    public GameObject prefab, parentobject, btn2, btn3;
    public GameObject obj1;

    public int x = 0;

    delete script;
    start script2;

    void Start()
    {
        parentobject = GameObject.Find("Cubes");
        prefab = (GameObject)Resources.Load("ketchap");
        // obj1 = Instantiate(prefab) as GameObject;
        // obj1.transform.SetParent(parentobject.transform, false);
        btn1 = GetComponent<Button>();
        btn2 = GameObject.Find("Button_del");
        script = btn2.GetComponent<delete>();
        btn3 = GameObject.Find("Button_start");
        script2 = btn3.GetComponent<start>();
        // btn1.interactable = false;
    }

    public void Onclick()
    {
        // parentobject.transform.position += new Vector3(0, 0, 0.7f);
        btn1.interactable = true;
        // script.btn2.interactable = true;
        obj1 = Instantiate(prefab) as GameObject;
        obj1.transform.SetParent(parentobject.transform, false);
        obj1.transform.position += new Vector3(0, 0, 0.7f * x);
        x++;
    }
}
