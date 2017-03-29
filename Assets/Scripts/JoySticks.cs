using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoySticks : MonoBehaviour
{

    // 조이스틱 판넬
    // 판넬을 바로 가져올수 있는게 아닉
    // 캔버스를 가져오고
    // 캔버스가 존재하면
    // 판넬을 가져오는 식인것 같다.
    Vector2 smallStick;


    private void Awake()
    {
        // 판넬 리턴 받기
    }

    void FixedUpdate()
    {
        // 마우스 움직임 값 추적
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Debug.Log(h + " " + v);
        // print(h + " " + v);
        // 마우스 동선 제한

    }

    void JoyStickMove(float h, float v)
    {
        smallStick.Set(h, v);
    }
}
