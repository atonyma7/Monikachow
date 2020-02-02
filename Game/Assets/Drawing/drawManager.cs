using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawManager : MonoBehaviour
{
    public GameObject drawPreFab;
    GameObject theTrail;
    Plane planeObj;
    Vector2 startPos;

    void Start()
    {
        planeObj = new Plane(Camera.main.transform.forward * -1, this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetMouseButtonDown(0))
        {
            theTrail = (GameObject)Instantiate(drawPreFab, this.transform.position, Quaternion.identity);
            BoxCollider tempBoxCollider = GetComponent<BoxCollider>();
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float _dis;
            if (planeObj.Raycast(mouseRay, out _dis))
            {
                startPos = mouseRay.GetPoint(_dis);
            }
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetMouseButton(0)) 
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float _dis;
            if (planeObj.Raycast(mouseRay, out _dis))
            {
                theTrail.transform.position = mouseRay.GetPoint(_dis);
            }
        }
    }
}
