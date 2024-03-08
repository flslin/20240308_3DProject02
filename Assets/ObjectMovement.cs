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

        // Mathf.Cos  �ﰢ�Լ� �ڻ��ΰ� ���
        // Mathf.Sin  �ﰢ�Լ� ���ΰ� ���
        // Mathf.Deg2Rad �Ϲ� ����(Degree)�� ����(Radian)���� ����
        // ������ �ѿ� ���� ���� ������ �߽����� �������� ���̸�ŭ �� �������� �������� �� �����ϴ� ������ ũ�� (�� 57.3��)
    }

}
