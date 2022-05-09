using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem
{

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
