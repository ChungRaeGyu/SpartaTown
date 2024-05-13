using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveMent(Vector2 direction){
        OnMoveEvent?.Invoke(direction); //InputSystem을 호출하는 방법 이고 SendMessage를 통해 같은 컴포넌트에 모두 뿌려준다.
    }
    public void CallLookMent(Vector2 direction){
        OnLookEvent?.Invoke(direction);
    }
}
