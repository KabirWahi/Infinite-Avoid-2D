using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    // Start is called before the first frame update
    public void goHome()
    {
        SceneManager.LoadScene(0);
    }
}
