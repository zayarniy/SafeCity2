using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update

    bool pause=false;
    public GameObject menu;
    void Start()
    {
    }

    private void Awake()
    {
        pause = false;
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = pause ? 1.0f : 0.0f;
            pause = !pause;
            menu.SetActive(pause);
        }

    }
}
