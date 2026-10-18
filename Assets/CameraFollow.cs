using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public float Cameraspeed; // The speed at which the camera will follow the target
    public float minX, maxX;
    public float minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // Calculate the desired position of the camera based on the target's position
            Vector2 newCameraPosition = Vector2.Lerp(transform.position, target.position, Time.deltaTime * Cameraspeed );
            float ClampX = Mathf.Clamp(newCameraPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCameraPosition.y, minY, maxY);
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
    }
}
