using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�q�I�u�W�F�N�g���O�������ꍇ
        if(transform.childCount == 0)
        {
            /// �N���A�V�[���ɑ@��
            // �e���������肢���܂�

            Debug.Log("�Q�[���N���A");
        }
    }
}
