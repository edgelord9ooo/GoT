using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;  
using System.Xml;
using System.Xml.Serialization; 
// The System.IO namespace contains functions related to loading and saving files

public class DataController : MonoBehaviour 
{

    private string gameDataFileName = "data.xml";

    void Start()
    {
    }

    public WesterosCardsIContainer LoadGameData()
    {
        // Path.Combine combines strings into a file path
        // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        Debug.Log("Loading file "+filePath);
        if(File.Exists(filePath))
        {
            var serializer = new XmlSerializer(typeof(WesterosCardsIContainer));
            var stream = new FileStream(filePath, FileMode.Open);
            var cardsI = serializer.Deserialize(stream) as WesterosCardsIContainer;
            stream.Close();
            // Retrieve the allRoundData property of loadedData
            return cardsI;
        }
        else
        {
            Debug.LogError("Cannot load game data!");
            return null;
        }
    }
}