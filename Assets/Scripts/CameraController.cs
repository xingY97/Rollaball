using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    //run after all the updates are done
    //the camera position wont move until the player unit has move to that frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
