using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }

    /// <summary>
    /// �Փ˂������Ɏ��s�����
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        // �Փ˂������肪Player�N���X�������Ă�����
        if (other.TryGetComponent(out Player player))
        {
            Destroy(gameObject);
        }
    }


}
