using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class NewGame : MonoBehaviour
{


    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        
    }
}