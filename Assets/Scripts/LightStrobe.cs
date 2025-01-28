using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class LightStrobe : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float size;

    public Vector2 start;
    public Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 scale  = transform.localScale;

        size += Time.deltaTime / 5;

        scale = Vector2.one * curve.Evaluate(size);
    }
}
