using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    Vector2 TargetPos;
    // Update is called once per frame
    void Update()
    {
        TargetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = TargetPos;
    }
}
