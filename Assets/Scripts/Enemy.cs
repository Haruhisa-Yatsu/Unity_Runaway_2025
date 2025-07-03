using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshを使用するために追加
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    /// <summary>
    /// NavmeshAgent 経路探索に使う
    /// </summary>
    [SerializeField]
    private NavMeshAgent _agent;

    /// <summary>
    /// 追いかける対象
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
        // 指定した位置に移動を開始する関数
        _agent.SetDestination(_player.position);
    }
}
