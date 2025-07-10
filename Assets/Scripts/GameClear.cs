using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SceneManager���g�p����̂ɕK�v
using UnityEngine.SceneManagement;
public class GameClear : MonoBehaviour
{
    /// <summary>
    /// ���͑ҋ@������b��
    /// </summary>
    private float _inputWaitSecond = 0.5f;

    /// <summary>
    /// �J�E���^
    /// </summary>
    private float _inputWaitCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _inputWaitCount += Time.deltaTime;

        if(_inputWaitCount >= _inputWaitSecond)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
