using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//플레이어가 키를 입력받는 곳입니다.
//TopDownController : InputAction을 관리하는 곳입니다.
public class PlayerInput : TopDownController
{
    Camera _camera;
    public void Awake(){
        _camera = Camera.main;
    }
    public void OnMove(InputValue value){
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveMent(moveInput);
    }

    public void OnLook(InputValue value){
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;
        CallLookMent(newAim);
    }
}
