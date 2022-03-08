using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public Sprite[] backgrounds;
    public SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, 14);
        rend.sprite = backgrounds[rand];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
