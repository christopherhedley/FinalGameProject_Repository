using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChHeGameControllerScript : MonoBehaviour {

    private float timer;
    private int wholetime;

    public ChHeAnimator script;

    public float temp;

    public GameObject startImage;
    public GameObject loseImage;
    public GameObject winImage;
    public Text endText;
    public Text tempText;

    void Start()
    {
        endText.text = "";
        temp = 10f;
        SetTempText();

        startImage.SetActive(true);
        loseImage.SetActive(false);
        winImage.SetActive(false);
    }

    void Update()
    {
      if(script.hasExhaled == false && Input.GetKeyDown(KeyCode.J))
        {
            temp = temp - 1;
            SetTempText();
        }
    }


    void FixedUpdate()
    {
      timer = timer + Time.deltaTime;
      if (timer >= 10)
            {

            loseImage.SetActive(true);
            Destroy(winImage);
               // endText.text = "Ouch! Burned Tongue";
               // StartCoroutine(ByeAfterDelay(2));
            }
    }



   void SetTempText()
   {
    tempText.text = "Temperature: " + temp.ToString();

    if (temp <= 0.0f)
        {
            winImage.SetActive(true);
            Destroy(loseImage);
           //endText.text = "Mmm, just right!!";
           // GameLoader.AddScore(10);
            //       StartCoroutine(ByeAfterDelay(2));
        }
     }


}

// IEnumerator ByeAfterDelay(float time)
// {
// yield return new WaitForSeconds(time);

// Code to execute after the delay
// GameLoader.gameOn = false;
// }