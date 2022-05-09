using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class get : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public static int highscore;
    // Start is called before the first frame update


    public static void SaveHighscore(int highscore)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/highscore.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, highscore);
        stream.Close();
    }

    public static int LoadHighscore()
    {
        string path = Application.persistentDataPath + "/highscore.dat";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        int highscore = (int)formatter.Deserialize(stream);
        stream.Close();

        return highscore;
}


    void Start()
    {
        int received = Score.score;
        scoreText.text = received.ToString();
        highscore = LoadHighscore();
        if (highscore < received)
        {
            highscore = received;
            SaveHighscore(highscore);

        }
        highscoreText.text = highscore.ToString();
    }



}
