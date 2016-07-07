using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour {

    //In global object:
    public GameInformation LocalCopyOfData;
    public bool IsSceneBeingLoaded = false;

    public void SaveData()
    {
        if (!Directory.Exists("Saves"))
            Directory.CreateDirectory("Saves");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create("Saves/save.sav");

        LocalCopyOfData = PlayerState.Instance.localPlayerData;

        formatter.Serialize(saveFile, LocalCopyOfData);

        saveFile.Close();
    }

    public void LoadData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open("Saves/save.sav", FileMode.Open);

        LocalCopyOfData = (GameInformation)formatter.Deserialize(saveFile);

        saveFile.Close();
    }
}
