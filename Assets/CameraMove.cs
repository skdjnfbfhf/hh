using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    private Vector3 pos = new Vector3(0, 8, -5);

   
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = player.transform.position + new Vector3(0, 8, -5) + pos;
    }
}
