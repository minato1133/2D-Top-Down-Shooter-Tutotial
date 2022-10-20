using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class chrono : MonoBehaviour
{
    float timer;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer.ToString();
        timer += Time.deltaTime;
        timerText.text = timerText.text = Mathf.Floor(timer).ToString();
        



    }
}
