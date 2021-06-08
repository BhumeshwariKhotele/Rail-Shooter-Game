using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float objectSpeed;
    [SerializeField]
    Vector3 objectDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectMovement(objectDirection,objectSpeed);
    }

    private void ObjectMovement(Vector3 direction,float speed)
    {
        transform.Translate(direction*speed*Time.deltaTime);
    }
}
