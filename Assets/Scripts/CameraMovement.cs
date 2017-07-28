using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3[] PositionPoints;
    public Vector3[] RotationPoints;

    public AnimationCurve PositionTransition;
    public AnimationCurve RotationTransition;

    public float Speed = 0.1f;

    public int CurrentPoint = 0;

    public int lastPoint;

    public float startTime;

    public float Threshold = 0.1f;

    void Start()
    {
        lastPoint = CurrentPoint;
        startTime = 0;
    }

    void Update()
    {
        float time = PositionTransition.Evaluate((Time.timeSinceLevelLoad - startTime) * Speed);

        float distance = Vector3.Distance(transform.position, PositionPoints[CurrentPoint]);

        if (distance < Threshold)
        {
            GetComponent<CameraMovement>().enabled = false;
        }

        transform.position = Vector3.Lerp(PositionPoints[lastPoint],
            PositionPoints[CurrentPoint], time);

        transform.rotation = Quaternion.Lerp(Quaternion.Euler(RotationPoints[lastPoint]),
            Quaternion.Euler(RotationPoints[CurrentPoint]), time);
    }

    public void MoveToPoint(int pointIndex)
    {
        GetComponent<CameraMovement>().enabled = true;
        lastPoint = CurrentPoint;
        CurrentPoint = pointIndex;

        startTime = Time.timeSinceLevelLoad;
    }
}