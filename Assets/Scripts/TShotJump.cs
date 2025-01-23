using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TShotJump : MonoBehaviour
{
    public AnimationCurve curve;

    float speed = 0.05f;

    public float timer = 0f;

    bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown("space"))
        {
            jumping = true;
        }

        if (jumping == true)
        {
            Timer();
        }
    }

    void Move()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.x <= -10 || squareInScreenSpace.x >= Screen.width)
        {
            speed = speed * -1;
        }

        pos.y = curve.Evaluate(timer) * 3;

        transform.position = pos;
    }

    void Timer()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            jumping = false;
        }
    }
}
