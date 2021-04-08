using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public GameObject lookme;
    public float velocity=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.smoothDeltaTime*velocity);
        transform.LookAt(lookme.transform);
    }
}
