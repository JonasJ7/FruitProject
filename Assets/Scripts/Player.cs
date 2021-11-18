using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed=6f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 direction = new Vector2(horizontal, 0f).normalized;

        if (direction.magnitude>=0.1f)
        {
           // ControllerColliderHit.Move(direction * Speed * Time.deltaTime);
        }
    }
}
