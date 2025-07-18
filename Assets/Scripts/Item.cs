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
    /// 衝突した時に実行される
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        // 衝突した相手がPlayerクラスを持っていたら
        if (other.TryGetComponent(out Player player))
        {
            Destroy(gameObject);
        }
    }


}
