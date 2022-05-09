using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class getHighscore : MonoBehaviour
{
    public Text highscoreText;

    public void Start()
    {
        int highscore = LoadHighscore();
        highscoreText.text = highscore.ToString();
    } 

    public static int LoadHighscore()
    {
        string path = Application.persistentDataPath + "/highscore.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            int highscore = (int)formatter.Deserialize(stream);
            stream.Close();

            return highscore;
        }
        else
        {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, 0);
        stream.Close();
        return 0;
        }
}
}
