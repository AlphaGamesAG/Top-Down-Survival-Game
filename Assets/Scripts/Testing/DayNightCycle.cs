
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    public Light Sun;
    [Range(0, 1)] public float lightIntensity = 1;
    public bool freezeCycle = false;
    public float waitTime = 7;
    public float restetTimeVal = 5;
    public float Speed = 1;
    public int Day = 1;
	
	void Update ()
    {

        Sun.intensity = lightIntensity;
        lightIntensity -= Time.deltaTime * Speed;

        float sunX = transform.rotation.eulerAngles.x;

        if(lightIntensity == 0)

        if (sunX >= 195)
        {
            freezeCycle = true;
            waitTime -= Time.deltaTime; //* Speed;
        }

        if(waitTime <= 0)
        {
            transform.Rotate(-transform.rotation.eulerAngles);
            waitTime = restetTimeVal;
            Day++;
            freezeCycle = false;
        }

        if (freezeCycle == false)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        }
    }

}
