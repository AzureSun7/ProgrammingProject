using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;

public class SavingProgress : MonoBehaviour
{
    public static SavingProgress manager;

    public saveData activeSave;

    public bool loaded;

    private void Awake()
    {
        manager = this;
        loadGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            saveGame();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            loadGame();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            deleteData();
        }
    }

    public void saveGame()
    {
        string dataPath = Application.persistentDataPath;
        var serializer = new XmlSerializer(typeof(saveData));
        var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Create);
        serializer.Serialize(stream, activeSave);

        Debug.Log("Game Saved");
    }

    public void loadGame()
    {
        string dataPath = Application.persistentDataPath;

        if (System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            var serializer = new XmlSerializer(typeof(saveData));
            var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Create);
            activeSave = serializer.Deserialize(stream) as saveData;
            stream.Close();

            Debug.Log("Loaded");

            loaded = true;
        }
    }

    public void deleteData()
    {
        string dataPath = Application.persistentDataPath;

        if (System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            File.Delete(dataPath + "/" + activeSave.saveName + ".save");
        }
    }
}

[System.Serializable]
public class saveData
{
    public string saveName;
    public Vector3 respawnPos;
    public int lives;
}

/*public int i;

   public void Save()
   {
       BinaryFormatter binaryFormatter = new BinaryFormatter();
       FileStream file = File.Create(filePath());
       binaryFormatter.Serialize(file, this);
       file.Close();
   }

   public void Load()
   {
       if (File.Exists(filePath))
       {
           BinaryFormatter binaryFormatter = new BinaryFormatter();
           FileStream file = File.Open(filePath(), FileMode.Open);
           SavingProgress loaded = binaryFormatter.Deserialize(file) as Brochure;
           i = loaded.i;
       }
   } 

   static string filePath()
   {
       return Application.persistentDataPath + "/SavingProgress.dat";
   }*/