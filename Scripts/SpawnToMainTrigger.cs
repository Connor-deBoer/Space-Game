using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnToMainTrigger : MonoBehaviour
{
    public Vector3 BDC;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainCamera") transform.DoorOpen(BDC);
    }
}
