using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMesh���g�p���邽�߂ɒǉ�
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _agent;

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
            _agent.nextPosition += 
                Vector3.forward * _velocity * Time.deltaTime;
        }
        // ���ړ�
        if (Input.GetKey(KeyCode.A))
        {
            _agent.nextPosition -= 
                Vector3.right * _velocity * Time.deltaTime;
        }
        // ��O�ړ�
        if (Input.GetKey(KeyCode.S))
        {
            _agent.nextPosition -= 
                Vector3.forward * _velocity * Time.deltaTime;
        }
        // �E�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            _agent.nextPosition += 
                Vector3.right * _velocity * Time.deltaTime;
        }
    }
}