using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_Controller : MonoBehaviour {

    public float moveSpeed;
    public float maxSpeed = 20;
    private float accSpeed;
    public Slider Speed;
    public GameObject chassis;
    public GameObject[] wheels;
    public Vector3 chassisPos = new Vector3();
    public float angle;

    /*
    Wheels[0]: Left Back
    Wheels[1]: Left Front
    Wheels[2]: Right Back
    Wheels[3]: Right Front
    */

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        accSpeed = 20 * Speed.value;
        if (moveSpeed < maxSpeed)
        {
            moveSpeed += accSpeed * Time.deltaTime;
        }
        foreach (GameObject wheel in wheels)
        {
            wheel.GetComponent<Rigidbody>().AddTorque(transform.right * moveSpeed * Time.deltaTime * 10);

            //Ensure front and back wheels stay the corrent distance apart
            if(wheel == wheels[0] || wheel == wheels[2])
            {
                Vector3 WheelPos = wheel.transform.position;
                if(wheel == wheels[0])
                {
                    WheelPos.x = wheels[1].transform.position.x + 2.74f;
                    WheelPos.z = wheels[1].transform.position.z;
                }
                else if(wheel == wheels[2])
                {
                    WheelPos.x = wheels[3].transform.position.x + 2.74f;
                    WheelPos.z = wheels[3].transform.position.z;
                }
                wheel.transform.position = WheelPos;
            }
            // Ensure wheels stay in line
            if(wheel == wheels[0])
            {
                wheel.transform.position = new Vector3(wheels[2].transform.position.x, wheel.transform.position.y, wheel.transform.position.z);
            }
            else if(wheel == wheels[1])
            {
                wheel.transform.position = new Vector3(wheels[3].transform.position.x, wheel.transform.position.y, wheel.transform.position.z);
            }
        }

        // Chassis Movement
        Vector3 WheelOffset = new Vector3((wheels[1].transform.position.x - wheels[2].transform.position.x) / 2, 0.75f, -wheels[0].transform.position.z);
        chassis.transform.position = wheels[0].transform.position + WheelOffset;


        // Chassis Rotation
        angle = Mathf.Asin((wheels[0].transform.position.y - wheels[1].transform.position.y) / 2.74f) * Mathf.Rad2Deg;

        if(angle < 0)
        {
            angle *= 2;
        }
        else if(angle > 0)
        {

        }

        float chassisAngle = chassis.transform.rotation.eulerAngles.x - angle;
        Quaternion rotation = Quaternion.Euler(270 + angle, 270, 0);
        chassis.transform.rotation = rotation;
    }
    
}
