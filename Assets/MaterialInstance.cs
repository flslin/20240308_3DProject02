using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInstance : MonoBehaviour
{
    // material을 적용할 매쉬 렌더러
    private MeshRenderer m_MeshRenderer;

    // 변경할 색
    [SerializeField]
    private Color color;

    // Start is called before the first frame update
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>(); // 기능을 가져옴
        m_MeshRenderer.material = Instantiate(m_MeshRenderer.material); // 가져온 머티리얼을 Instantiate로 생성 (복제)
        m_MeshRenderer.material.color = color; // material의 색을 설정한 색으로 변경
    }

}
