using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float size;

    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the player presses the left mouse button, do this code
        if (Input.GetMouseButton(0))
        {
            //increases the size over time, slowed to make it look better
            size += Time.deltaTime / 2;

            //lerps the scale of the light from the start size to the end size
            transform.localScale = Vector2.Lerp(start.localScale, end.localScale, curve.Evaluate(size));
        }
        //if the player isn't holding down the left mouse button, do this
        else
        {
            //set the size of the light to 0
            size = 0;
        }
    }
}
