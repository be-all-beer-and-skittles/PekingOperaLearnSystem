using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_ConsoleCurrent : MonoBehaviour
{
    public Transform RightUpperArm;
    public Transform RightForeArm;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("RightUpperArm: " + RightUpperArm.transform.localEulerAngles);
            Debug.Log("RightForeArm: " + RightForeArm.transform.localEulerAngles);

            Debug.Log("current: " + 
                "x" + GetCurrentEulerAngle(RightUpperArm, RightForeArm).x + "\n" +
                "y" + GetCurrentEulerAngle(RightUpperArm, RightForeArm).y + "\n" +
                "z" + GetCurrentEulerAngle(RightUpperArm, RightForeArm).z);
        }
    }

    public Vector3 GetCurrentEulerAngle(Transform transform1, Transform transform2)
    {
        Vector3 currentEulerAngle = transform1.eulerAngles - transform2.eulerAngles;
        return currentEulerAngle;
    }
}
