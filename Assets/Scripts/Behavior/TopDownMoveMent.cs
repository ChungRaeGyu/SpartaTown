using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMoveMent : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Vector2 playerDirection = Vector2.zero;
    private TopDownController controller;
    private void Awake() {
        rigid = GetComponent<Rigidbody2D>();
        controller = GetComponent< TopDownController>();
    }
    private void Start()
    {
        //+=이벤트핸들러 등록하는 법
        controller.OnMoveEvent += Move;
    }
    //InputSystem 에서 뿌려준 값을 등록된 이벤트핸들러에서 받아준다.
    private void Move(Vector2 direction){
        playerDirection = direction;
    }
    private void FixedUpdate()
    {
        //여기는 물리 업데이트 관련
        //rigidbody는 물리
        ApplyMovement(playerDirection);
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5f;
        rigid.velocity = direction;
    }
}
