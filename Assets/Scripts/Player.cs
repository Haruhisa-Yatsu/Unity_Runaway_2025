using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshを使用するために追加
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _agent;

    /// <summary>
    /// 移動の速さ
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
        // 奥移動
        if (Input.GetKey(KeyCode.W))
        {
            _agent.nextPosition += 
                Vector3.forward * _velocity * Time.deltaTime;
        }
        // 左移動
        if (Input.GetKey(KeyCode.A))
        {
            _agent.nextPosition -= 
                Vector3.right * _velocity * Time.deltaTime;
        }
        // 手前移動
        if (Input.GetKey(KeyCode.S))
        {
            _agent.nextPosition -= 
                Vector3.forward * _velocity * Time.deltaTime;
        }
        // 右移動
        if (Input.GetKey(KeyCode.D))
        {
            _agent.nextPosition += 
                Vector3.right * _velocity * Time.deltaTime;
        }
    }
}