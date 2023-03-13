using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePass : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI textTimePass;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTimePass.text = "Time:"+Time.timeSinceLevelLoad.ToString("F1");
    }
}
