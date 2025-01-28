using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class LightStrobe : MonoBehaviour
{
    public AnimationCurve curve;

    public float size;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        size += Time.deltaTime / 5;

        transform.localScale = Vector2.one * curve.Evaluate(size);
    }
}
