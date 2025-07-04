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
    /// Õ“Ë‚µ‚½‚ÉÀs‚³‚ê‚é
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        // Õ“Ë‚µ‚½‘Šè‚ªPlayerƒNƒ‰ƒX‚ğ‚Á‚Ä‚¢‚½‚ç
        if (other.TryGetComponent(out Player player))
        {
            Destroy(gameObject);
        }
    }


}
