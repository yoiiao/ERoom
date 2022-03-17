using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour

{
    public float interactDiastance = 0.2f;
    DoorScript door;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("SPACE");
            Ray ray = new Ray(transform.position, transform.forward); RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDiastance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    print("SPACE+DOOR");
                    //hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
                    hit.collider.transform.GetComponent<DoorScript>().ChangeDoorState();
                }
            }
        }
    }
}


