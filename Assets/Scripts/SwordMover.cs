using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //finds mouse position in the screen 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //moves the sword with the mouse as long as the left button is down and it isn't too low
        if (Input.GetMouseButton(0) && mousePos.y > -2)
        {
            transform.position = mousePos;
        }
    }
}