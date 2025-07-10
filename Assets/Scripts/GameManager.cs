using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //子オブジェクトが０個だった場合
        if(transform.childCount == 0)
        {
            /// クリアシーンに繊維
            // 各自実装お願いします
            SceneManager.LoadScene("GameClear");
            Debug.Log("ゲームクリア");
        }
    }
}
