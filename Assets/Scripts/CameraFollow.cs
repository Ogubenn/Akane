using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = .3f;
    public Vector3 offsett;
    private Vector3 velocity = Vector3.zero;


    private void Update()
    {
        if(target != null)
        {
            Vector3 targetPosition = target.position + offsett;

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition,ref velocity,smoothTime);    
        }
    }




}//class