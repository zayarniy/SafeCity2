using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{

    public GameObject teleportTo;
    public static event System.Action<int> LivesUpdate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger enter");
        if (other.tag == "Player")
        {
            if (this.tag == "death")
            {
                LivesUpdate?.Invoke(-1);
                if (GameManager.lifes <=0)
                {
                    SceneManager.LoadScene(6);
                    GameManager.StartGame = true;

                }
            }
            GameManager.StopAllVideo();
            other.transform.position = teleportTo.transform.position;
        }

    }

}
