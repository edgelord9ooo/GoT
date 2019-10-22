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
        Debug.Log("datacontroller online");
        DontDestroyOnLoad(gameObject);

        LoadGameData();

        // LoadPlayerProgress();

        // SceneManager.LoadScene("MenuScreen");
    }
    public string westeros;

    // public void SubmitNewPlayerScore(int newScore)
    // {
    //     // If newScore is greater than playerProgress.highestScore, update playerProgress with the new value and call SavePlayerProgress()
    //     if(newScore > playerProgress.highestScore)
    //     {
    //         playerProgress.highestScore = newScore;
    //         SavePlayerProgress();
    //     }
    // }

    // public int GetHighestPlayerScore()
    // {
    //     return playerProgress.highestScore;
    // }

    private void LoadGameData()
    {
        // Path.Combine combines strings into a file path
        // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        Debug.Log("attempting now");
        Debug.Log(filePath);
        if(File.Exists(filePath))
        {
            Debug.Log("yes it exists@!");
            var serializer = new XmlSerializer(typeof(WesterosCardsIContainer));
            var stream = new FileStream(filePath, FileMode.Open);
            var cardsI = serializer.Deserialize(stream) as WesterosCardsIContainer;
            stream.Close();
            // Retrieve the allRoundData property of loadedData
            Debug.Log(cardsI.WesterosCardsI[0].Description);
            Debug.Log(cardsI.WesterosCardsII[0].Description);
        }
        else
        {
            Debug.LogError("Cannot load game data!");
        }
    }

    //// This function could be extended easily to handle any additional data we wanted to store in our PlayerProgress object
    // private void LoadPlayerProgress()
    // {
    //     // Create a new PlayerProgress object
    //     playerProgress = new PlayerProgress();

    //     // If PlayerPrefs contains a key called "highestScore", set the value of playerProgress.highestScore using the value associated with that key
    //     if(PlayerPrefs.HasKey("highestScore"))
    //     {
    //         playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
    //     }
    // }

    // // This function could be extended easily to handle any additional data we wanted to store in our PlayerProgress object
    // private void SavePlayerProgress()
    // {
    //     // Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
    //     PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    // }
}