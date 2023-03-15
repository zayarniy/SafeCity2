using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int lifes = 3;
    static bool NeedInit = true;
    public static bool StartGame = true;
    

    static TMPro.TextMeshProUGUI textScore;
    static TMPro.TextMeshProUGUI textLifes;

    //public Canvas scoreCanvas;

    private static GameManager instance;
    public static GameManager Instance => instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance)
        {
            DestroyImmediate(instance);
            return;
        }
        else
        {
            instance = this;
            if (StartGame)
            {
                lifes = 3;
                score = 0;
                StartGame = false;
                {
                    SimpleCollectibleScript.ScoreUpdate += ScoreUpdate;
                    Teleport.LivesUpdate += LifesUpdate;
                    NeedInit = false;
                }

            }
            //if (NeedInit)
        }
        //print(textScore);
    }

    
    private void Start()
    {
        //SimpleCollectibleScript.ScoreUpdate += ScoreUpdate;
        //Teleport.LivesUpdate += LifesUpdate;
        print(SceneManager.GetActiveScene().name+" loaded");
        textScore = GameObject.FindObjectsOfType<TextMeshProUGUI>().FirstOrDefault(obj => obj.name == "Score");
        //textScore.text = $"Score:{score.ToString("G3")}";
        textLifes = GameObject.FindObjectsOfType<TextMeshProUGUI>().FirstOrDefault(obj => obj.name == "Lifes");
        ScoreUpdate(0);
        LifesUpdate(0);
//        textLifes.text = $"Lifes:{lifes}";
    }



    // Update is called once per frame
    void Update()
    {
        //AudioListener.volume += Input.mouseScrollDelta.y;
    }

    public void Mute()
    {
        AudioListener.volume = 0;
    }

    public void UnMute()
    {
        AudioListener.volume = 1;
    }
    public void ScoreUpdate(int _score=1)
    {
        GameManager.score += _score;
        //print(System.DateTime.Now);
        //print(textScore);
        if (score >= 50)
            textScore.color = Color.green;
        else
            textScore.color = Color.white;
        textScore.text = $"Score:{score}";
        //canvas.enabled = false;
    }

    public void LifesUpdate(int _life)
    {
        GameManager.lifes += _life;
        textLifes.text = $"Lifes:{GameManager.lifes}";
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ScoreScene()
    {
        SceneManager.LoadScene("Results");
        PlayerPrefs.SetString("Results", string.Join("\n", GameManager.score));
    }

}
