using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Main;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Main.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Main.transform.position + offset;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
