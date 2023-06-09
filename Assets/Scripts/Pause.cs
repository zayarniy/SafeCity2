using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

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
        pause = true;
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
        if (Input.GetKeyUp(KeyCode.S) && Input.GetButton("Fire1"))
        {
            var videoplayers = GameObject.FindObjectsOfType<VideoPlayer>();
            foreach (var videoplayer in videoplayers)
                videoplayer.Stop();
        }


    }
}
