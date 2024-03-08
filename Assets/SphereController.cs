using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    //트랜스폼(Transform)
    // 위치, 회전, 크기 표현에 사용
    // 부모 자식 상태를 저장하기 위해서도 사용
    // 게임 오브젝트에는 항상하나의 트랜스폼 컴포넌트가 존재
    // 트랜스폼이 없는 게임 오브젝트는 생성할수 없음

    // Scale은 1이 기본크기(오브젝트가 import 된 크기), 수치에 따라 비례하게 설정
    // Scale 옆의 체크를 풀 경우 비례 스케일링 기능 활성화
    // 설정해 놓은 x, y, z를 기준으로 값을 증가 시키면 x, y, z에 같이 적용

    // Input.GetKey : 입력기능 중 해당 키를 누르는 동안을 표현
    // Input.GetKeyDown : 해당 키를 입력했을 때 (1번)
    // Input.GetKeyUp : 해당 키를 입력하고 뗐을 때 (1번)

    Vector3 rotation;
    public void Start()
    {
        rotation = transform.eulerAngles; // transform.eulerAngles는 오브젝트의 transform의 rotation값을 Vector3의 형태로 변환하는 코드
        // 오일러각은 공식문서와 디코자료 참고

        // 문제점 : eulerAngles 수치를 직접 증가시킬 경우 오브젝트가 90도 이상 돌지않고 떨게 됨 - 짐벌락 현상
        // 해결법 : 계산식을 적을 때 Quaternion으로 계산을 처리
        // Quaternion : 사원수. 3차원 그래픽에서 회전을 표현할 때 행렬 대신 사용하는 수학적 개념을 의미
        // 쿼터니언은 x, y, z 백터와 w(스칼라)를 통해 계산을 진행
        // 수학적으로 쿼터니언은 x, y, z와 w를 묶어서 구성한 복소수. w(스칼라)는 실수, x, y, z는 허수에 해당
        // 결론 : 쿼터니언으로 계산할 경우 x, y, z축을 다 회전하는 것이 가능
    }

    // Update is called once per frame
    void Update()
    {
        // 오브젝트 이동
        // 1. 현재 위치를 다른 지점으로 초기화해 좌표 이동하는 방법
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 2) * Time.deltaTime;
            //transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        }

        // 2. transform.Translate(이동할 좌표)를 통해 좌표를 이동하는 방법
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotation);

            //Quaternion.LookRotation(); // 지정된 upward 방향들로  rotation을 생성하는 코드
            //Quaternion.Euler(); // 각 축이 회전한 순서대로  rotation을 반환하는 기능
            //Quaternion.Angle(a, b); // 쿼터니언 값 a, b 사이의 각도를 반환하는 기능
            //Quaternion.Slerp(a, b, t); a와 b사이를 t간격으로 구형 보간(부드러운 이동). 비슷한 기능 Mathf.Lerp(a, b, t) -> 선형보간
            // Quaternion.identity : 회전 값이 없음을 의미(오브젝트가 월드좌표/부모의 축으로 정렬)
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime); // Rotate 현재 오브젝트가 가진 transform에 넣어준 수치만큼 + 하는 개념
        }

        if (Input.GetKey(KeyCode.S))
        {
            rotation += new Vector3(0, 0, 90) * Time.deltaTime;
            transform.eulerAngles = rotation; // 오일러 각(절대 각도)에 회전값 초기화
        }
    }
}
