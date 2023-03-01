using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public int noteSpeed = 5;
    void Update()
    {
        transform.position -= transform.forward * Time.deltaTime * noteSpeed;
    }
}
