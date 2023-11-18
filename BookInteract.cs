using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookInteract : MonoBehaviour
{
    public GameObject mapUI;
    void Start()
    {
        mapUI.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mapUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mapUI.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
