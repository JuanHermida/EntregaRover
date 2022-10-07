using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Conducir : MonoBehaviour
{

    public WheelCollider Llanta1;
    public WheelCollider Llanta2;
    public WheelCollider Llanta3;
    public WheelCollider Llanta4;
    public int desAceleracion = 50;


    public int vel = 200;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Llanta1.motorTorque = vel * Input.GetAxis("Vertical");
        Llanta2.motorTorque = vel * Input.GetAxis("Vertical");

        if (Input.GetAxis("Vertical") == 0)
        {
            Llanta1.brakeTorque = desAceleracion;
            Llanta2.brakeTorque = desAceleracion;
        }
        else
        {
            Llanta1.brakeTorque = 0;
            Llanta2.brakeTorque = 0;
        }
        //rotacion
        Llanta3.steerAngle = -10 * Input.GetAxis("Horizontal");
        Llanta4.steerAngle = -10 * Input.GetAxis("Horizontal");

        //if (Input.GetButtonUp (KeyCode.UpArrow))

    }
}
