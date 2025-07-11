using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// TextMeshPro�������ۂɕK�v
using TMPro;


public class GameManager: MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;

    /// <summary>
    /// �J�n���ɑ��݂���A�C�e���̐�
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

        //�q�I�u�W�F�N�g���O�������ꍇ
        if(transform.childCount == 0)
        {
            /// �N���A�V�[���ɑ@��
            // �e���������肢���܂�
            SceneManager.LoadScene("GameClear");
            Debug.Log("�Q�[���N���A");
        }
    }
}
