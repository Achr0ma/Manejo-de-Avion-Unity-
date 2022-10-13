using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 playerPreviousPos = Vector3.zero;
    private float distance = 20f;
    //private Vector3 offset = new Vector3(0,5,-7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = plane.transform.position - playerPreviousPos;
        if (offset.magnitude < 0.3f)
        {
            return;
        }

        offset.Normalize();
        this.transform.position = plane.transform.position - offset * distance;

        this.transform.LookAt(plane.transform.position);
        playerPreviousPos = plane.transform.position;
    }
}
