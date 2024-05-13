using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private TopDownController controller;
    [SerializeField]private SpriteRenderer spriteRenderer;
    
    private void Awake() {
        controller = GetComponent<TopDownController>();

    }
    private void Start() {
        controller.OnLookEvent += Look;
    }

    private void Look(Vector2 vector)
    {
        //마우스값을 받아왔다.
        float rotZ = Mathf.Atan2(vector.y, vector.x)* Mathf.Rad2Deg;
        spriteRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
