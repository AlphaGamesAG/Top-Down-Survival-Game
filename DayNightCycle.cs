
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    public float Speed;
    public int Day = 1;
    public bool newDay = false;
    public int currentTime;
	
	void Update ()
    {

        transform.Rotate(Vector3.right * Time.deltaTime * Speed);

        float sunX = transform.rotation.eulerAngles.x;

        if (sunX >= 195)
        {
            transform.Rotate(-transform.rotation.eulerAngles);
            NewDay();
        }

       currentTime = Mathf.RoundToInt(sunX);
    }



    void NewDay ()
    {
        Day++;
    }
}
