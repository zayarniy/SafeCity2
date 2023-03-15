using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Finish;
    public TMPro.TextMeshProUGUI textFinish;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textFinish.text = $"Distance:{Vector3.Distance(this.transform.position, Finish.position).ToString("F0")}";
    }
}
