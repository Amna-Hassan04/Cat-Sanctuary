using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotate : MonoBehaviour
{
        public int rotateSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);

    }
}
