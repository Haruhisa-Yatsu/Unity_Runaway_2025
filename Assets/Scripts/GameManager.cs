using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// TextMeshProを扱う際に必要
using TMPro;


public class GameManager: MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;

    /// <summary>
    /// 開始時に存在するアイテムの数
    /// </summary>
    private int _startItemCount;

    // Start is called before the first frame update
    void Start()
    {
        _startItemCount = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = $" {_startItemCount - transform.childCount} / {_startItemCount}";

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
