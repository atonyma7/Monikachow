using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 temp = Input.mousePosition;
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}
