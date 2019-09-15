using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem
{
    public static void SaveStatus(StatusManager SM)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/status.dfz";
        FileStream stream = new FileStream(path, FileMode.Create);

        Status status = new Status(SM); //prepare data for saving

        formatter.Serialize(stream, status);
        stream.Close();

    }

    public static Status LoadStatus()
    {
        string path = Application.persistentDataPath + "/status.dfz";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Status status = formatter.Deserialize(stream) as Status;
            stream.Close();

            return status;
            
        }
        else
        {
            Debug.LogError("Save file not found at: " + path);
            return null;
        }
    }


}
