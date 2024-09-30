using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Vector3 desiredpos;
    public float stiffness= 10f;
    // Update is called once per frame
    void FixedUpdate()
    {
        desiredpos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredpos, stiffness * Time.deltaTime);
      
    }
}
