using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPos : MonoBehaviour {

    public Transform target;
    public Transform endPos;
    public float speed = 10;
    //public float minSpeed;
    //public float maxSpeed;
    //public float duration = 5.0f;
    private bool isMoving = false;

    //private float startTime;



    void Start ()
    {
        //startTime = Time.time;
    }

	void Update ()
    {
        float step = speed * Time.smoothDeltaTime;
        //float step = speed * Time.deltaTime;
        //float t = (Time.time - startTime) / duration;
        //float step = Mathf.SmoothStep(minSpeed, maxSpeed, t);

        if (isMoving == true)
        {
            target.position = Vector3.MoveTowards(target.position, endPos.position, step);
        }

        if (target.position == endPos.position)
        {
            isMoving = false;
        }

        //Vector3.Lerp(currentStartPos.position, currentEndPos.position, Time.deltaTime * speed);
    }

    public void Move(bool Move)
    {
        isMoving = Move;
    }
}
