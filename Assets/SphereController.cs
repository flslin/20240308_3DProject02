using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    //Ʈ������(Transform)
    // ��ġ, ȸ��, ũ�� ǥ���� ���
    // �θ� �ڽ� ���¸� �����ϱ� ���ؼ��� ���
    // ���� ������Ʈ���� �׻��ϳ��� Ʈ������ ������Ʈ�� ����
    // Ʈ�������� ���� ���� ������Ʈ�� �����Ҽ� ����

    // Scale�� 1�� �⺻ũ��(������Ʈ�� import �� ũ��), ��ġ�� ���� ����ϰ� ����
    // Scale ���� üũ�� Ǯ ��� ��� �����ϸ� ��� Ȱ��ȭ
    // ������ ���� x, y, z�� �������� ���� ���� ��Ű�� x, y, z�� ���� ����

    // Input.GetKey : �Է±�� �� �ش� Ű�� ������ ������ ǥ��
    // Input.GetKeyDown : �ش� Ű�� �Է����� �� (1��)
    // Input.GetKeyUp : �ش� Ű�� �Է��ϰ� ���� �� (1��)

    Vector3 rotation;
    public void Start()
    {
        rotation = transform.eulerAngles; // transform.eulerAngles�� ������Ʈ�� transform�� rotation���� Vector3�� ���·� ��ȯ�ϴ� �ڵ�
        // ���Ϸ����� ���Ĺ����� �����ڷ� ����

        // ������ : eulerAngles ��ġ�� ���� ������ų ��� ������Ʈ�� 90�� �̻� �����ʰ� ���� �� - ������ ����
        // �ذ�� : ������ ���� �� Quaternion���� ����� ó��
        // Quaternion : �����. 3���� �׷��ȿ��� ȸ���� ǥ���� �� ��� ��� ����ϴ� ������ ������ �ǹ�
        // ���ʹϾ��� x, y, z ���Ϳ� w(��Į��)�� ���� ����� ����
        // ���������� ���ʹϾ��� x, y, z�� w�� ��� ������ ���Ҽ�. w(��Į��)�� �Ǽ�, x, y, z�� ����� �ش�
        // ��� : ���ʹϾ����� ����� ��� x, y, z���� �� ȸ���ϴ� ���� ����
    }

    // Update is called once per frame
    void Update()
    {
        // ������Ʈ �̵�
        // 1. ���� ��ġ�� �ٸ� �������� �ʱ�ȭ�� ��ǥ �̵��ϴ� ���
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 2) * Time.deltaTime;
            //transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        }

        // 2. transform.Translate(�̵��� ��ǥ)�� ���� ��ǥ�� �̵��ϴ� ���
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotation);

            //Quaternion.LookRotation(); // ������ upward ������  rotation�� �����ϴ� �ڵ�
            //Quaternion.Euler(); // �� ���� ȸ���� �������  rotation�� ��ȯ�ϴ� ���
            //Quaternion.Angle(a, b); // ���ʹϾ� �� a, b ������ ������ ��ȯ�ϴ� ���
            //Quaternion.Slerp(a, b, t); a�� b���̸� t�������� ���� ����(�ε巯�� �̵�). ����� ��� Mathf.Lerp(a, b, t) -> ��������
            // Quaternion.identity : ȸ�� ���� ������ �ǹ�(������Ʈ�� ������ǥ/�θ��� ������ ����)
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime); // Rotate ���� ������Ʈ�� ���� transform�� �־��� ��ġ��ŭ + �ϴ� ����
        }

        if (Input.GetKey(KeyCode.S))
        {
            rotation += new Vector3(0, 0, 90) * Time.deltaTime;
            transform.eulerAngles = rotation; // ���Ϸ� ��(���� ����)�� ȸ���� �ʱ�ȭ
        }
    }
}
