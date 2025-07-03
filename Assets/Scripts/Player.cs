using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// �ړ��̑���
    /// </summary>
    [SerializeField]
    private float _velocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ���ړ�
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += 
                Vector3.forward * _velocity * Time.deltaTime;
        }
        // ���ړ�
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= 
                Vector3.right * _velocity * Time.deltaTime;
        }
        // ��O�ړ�
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= 
                Vector3.forward * _velocity * Time.deltaTime;
        }
        // �E�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += 
                Vector3.right * _velocity * Time.deltaTime;
        }
    }
}