using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : AnimationController
{
    public static readonly int isWalking = Animator.StringToHash("isWalking");
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        Debug.Log(""+vector.magnitude);
        //magnitude = 벡터의 크기
        animator.SetBool(isWalking, vector.magnitude > 0.1f);
    }
}
