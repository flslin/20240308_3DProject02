using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //[SerializeField] private float speed = 1.0f;
    //[SerializeField] private float radius = 1.0f;

    Vector3 pos;

    private void Update()
    {
        pos.x = Mathf.Cos(Time.time * 360 * Mathf.Deg2Rad);
        pos.z = Mathf.Sin(Time.time * 360/*speed*/ * Mathf.Deg2Rad);
        transform.position = pos;

        // Mathf.Cos  삼각함수 코사인값 계산
        // Mathf.Sin  삼각함수 사인값 계산
        // Mathf.Deg2Rad 일반 각도(Degree)를 라디안(Radian)으로 변경
        // 라디안은 한원 위의 점이 원점으 중심으로 반지름의 길이만큼 한 방향으로 움직였을 때 대응하는 가그이 크기 (약 57.3도)
    }

}
