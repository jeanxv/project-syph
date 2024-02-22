using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public class Countdown : MonoBehaviour
    {
        public float timeStart = 10;
        public Text textbox;

        void Start()
        {
            textbox.text = timeStart.ToString();
        }

        void Update()
        {
            timeStart -= Time.deltaTime;
            textbox.text = Mathf.Round(timeStart).ToString();
            if (timeStart > 0) 
            {
                SceneManager.LoadSceneAsync(0);
                Debug.Log("helo");
            }
            
        }
    }
}
