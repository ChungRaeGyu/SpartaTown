using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//플레이어가 키를 입력받는 곳입니다.
//TopDownController : InputAction을 관리하는 곳입니다.
public class PlayerInput : TopDownController
{
    public void OnMove(InputValue value){
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveMent(moveInput);
    }
}
