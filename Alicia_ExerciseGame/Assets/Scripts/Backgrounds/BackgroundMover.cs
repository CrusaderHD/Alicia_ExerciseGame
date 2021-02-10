using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed *Time.deltaTime);
    }
}
