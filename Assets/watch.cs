using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watch : MonoBehaviour
{
    public Text warningText;
    // Start is called before the first frame update

    private float timeToAppear = 51.5f;
    private float timeToDisappear = 53.75f;
    private float time;

    void Start()
    {
        DisableText();
    }

    void Update(){
        time = Time.timeSinceLevelLoad;

        if (time >= timeToAppear){
            EnableText();
            timeToAppear = time + 10f;
        }

        if (time >= timeToDisappear){
            DisableText();
            timeToDisappear = time + 10f;
        }

    
    }

    public void EnableText(){
        warningText.enabled = true;
    }

    public void DisableText(){
        warningText.enabled = false;
    }
}
