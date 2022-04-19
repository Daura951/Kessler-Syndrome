using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition9 : MonoBehaviour
{

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector2(0, 1 * speed));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Uwu");
        if(collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(16);
        }
    }
}
