using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class LightStrobe : MonoBehaviour
{
    //creating the animation curve and making it public to edit in the inspector
    public AnimationCurve curve;

    //creating the size variable that will change over time
    public float size;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //making the size increase at a constant rate
        size += Time.deltaTime / 5;

        //actually setting the size to change based on the curve 
        transform.localScale = Vector2.one * curve.Evaluate(size);
    }
}
