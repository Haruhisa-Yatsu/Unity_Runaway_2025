using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SceneManagerを使用するのに必要
using UnityEngine.SceneManagement;
public class GameClear : MonoBehaviour
{
    /// <summary>
    /// 入力待機させる秒数
    /// </summary>
    private float _inputWaitSecond = 0.5f;

    /// <summary>
    /// カウンタ
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
