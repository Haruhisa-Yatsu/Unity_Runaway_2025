using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMesh���g�p���邽�߂ɒǉ�
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    /// <summary>
    /// NavmeshAgent �o�H�T���Ɏg��
    /// </summary>
    [SerializeField]
    private NavMeshAgent _agent;

    /// <summary>
    /// �ǂ�������Ώ�
    /// </summary>
    [SerializeField]
    private Transform _player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // �w�肵���ʒu�Ɉړ����J�n����֐�
        _agent.SetDestination(_player.position);
    }
}
