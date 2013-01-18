using UnityEngine;
using System.Collections;

public class MarbleCamera : MonoBehaviour {

    /*
    public Transform target;
    public float damping = 6.0f;
    public bool smooth = true;

    void Start()
    {
        if (rigidbody)
        {
            rigidbody.freezeRotation = true;
        }
    }

    void LateUpdate()
    {
        if (target)
        {
            if (smooth)
            {
                Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
            }
            else
            {
                transform.LookAt(target);
            }
        }
    }

    */
    public Transform target;
	public float relativeHeigth = 10.0f;
    public float zDistance = 5.0f;
    public float dampSpeed = 2;

    void Update () {
        Vector3 newPos = target.position + new Vector3(0, relativeHeigth, -zDistance);
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*dampSpeed);
	}
     
}
