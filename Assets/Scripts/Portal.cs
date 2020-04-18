using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Vector3 TPCoords;

    private Vector3 boxCenter;
    private Vector3 halfExtents;
    private Quaternion orientation;
    private LayerMask layerMask;
    public bool inPortal;
    // Start is called before the first frame update
    void Start()
    {
        boxCenter = gameObject.transform.position;
        halfExtents.x = 6f;
        halfExtents.y = 10f;
        halfExtents.z = 0.5f;
        orientation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        inPortal = Physics.CheckBox(boxCenter, halfExtents, orientation, layerMask);

        if(inPortal){

        }
    }

    void OnCollisionEnter(Collision col){
        Debug.Log("Colliding");
        if(col.gameObject.name == "Capsule"){
            Debug.Log(col.gameObject.name);
            col.gameObject.transform.position = TPCoords;
        }
    }
}
