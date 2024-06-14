using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Camera cam;

    Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0);
    }

    private void FixedUpdate()
    {
        transform.LookAt(mousePos); //This makes the gameobject 'look at the mouse' so it shoots in the right direction
    }
}
