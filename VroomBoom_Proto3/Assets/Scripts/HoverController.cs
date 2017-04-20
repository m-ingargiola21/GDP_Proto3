using UnityEngine;
using System.Collections;

public class HoverController : MonoBehaviour
{
    [SerializeField] GameObject hoverCraft;

    [SerializeField] private float maxSteeringAngle = 30;
    [SerializeField] private float maxMotorTorque = 400;
    [SerializeField] private float brakeTorque = 400;


    [SerializeField] private WheelCollider[] wheelsUsedForSteering;
    [SerializeField] private WheelCollider[] wheelsUsedForDriving;
    [SerializeField] private WheelCollider[] allWheelColliders;

    [SerializeField] float hoverCraftPosX;
    [SerializeField] float hoverCraftPosY;
    [SerializeField] float hoverCraftPosZ;

    public string verticleAxis = "Vertical_P1";
    public string horizontalAxis = "Horizontal_P1";
    public string flipButton = "Jump_P1";

    private float driveInput;
    private float steeringInput;
    private float flippingInput;
    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame, need * Time.deltaTime;
    void Update()
    {
        driveInput = Input.GetAxis(verticleAxis);
        steeringInput = Input.GetAxis(horizontalAxis);
        if (Input.GetButton(flipButton))
        {
            hoverCraft.transform.position = new Vector3(hoverCraftPosX, hoverCraftPosY,hoverCraftPosZ);
        }

       //if(hoverCraft.transform.rotation.x >=9 | hoverCraft.transform.rotation.y >= 45| hoverCraft.transform.rotation.x >= 0)
       // {
       //     hoverCraft.transform.position = new Vector3(hoverCraftPosX, hoverCraftPosY, hoverCraftPosZ);

       // }

    }

    //called every fixed interval of time, don't need * Time.deltaTime;
    private void FixedUpdate()
    {
        //for loop for an array
        for (int i = 0; i < wheelsUsedForSteering.Length; i++)
        {
            wheelsUsedForSteering[i].steerAngle = maxSteeringAngle * steeringInput;
        }

        for (int i = 0; i < wheelsUsedForDriving.Length; i++)
        {
            wheelsUsedForDriving[i].motorTorque = maxMotorTorque * driveInput;
        }

        //brakes
        //when forward velocity is one direction and our input is the opposite direction
        float forwardVelocity = transform.InverseTransformDirection(rigidBody.velocity).z;

        bool carIsMovingSameDirectionAsInput = (forwardVelocity > 0) == (driveInput > 0);

        float brakeTorqueToApply = 0;

        if (!carIsMovingSameDirectionAsInput)
        {
            brakeTorqueToApply = brakeTorque;
        }
        for (int i = 0; i < allWheelColliders.Length; i++)
        {
            allWheelColliders[i].brakeTorque = brakeTorqueToApply;
        }
    }
}
