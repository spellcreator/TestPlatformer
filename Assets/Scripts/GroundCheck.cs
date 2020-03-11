using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;
    private Collider2D cColider2d;
    private bool isGrounded;
    //[SerializeField] private Transform groundCheck;

    private void Awake()
    {
        cColider2d = GetComponent<CircleCollider2D>();
    }

    private void FixedUpdate()
    {
        float extraHeight = 0.1f;
        RaycastHit2D hit = Physics2D.Raycast(cColider2d.bounds.center, Vector2.down, cColider2d.bounds.extents.y + extraHeight, groundLayer);
        
    }


}
