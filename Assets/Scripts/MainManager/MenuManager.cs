using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject textEditor, bestPlayer;
    public static string name;
    // Start is called before the first frame update
    void Start()
    {
        MainManager.LoadGame();
        bestPlayer.GetComponent<TMPro.TextMeshProUGUI>().text = MainManager.bestPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (textEditor.GetComponent<TMPro.TMP_InputField>().text.ToString().Equals(""))
        {
            name = "Invited";
        }
        else
        {
            name = textEditor.GetComponent<TMPro.TMP_InputField>().text;
        }
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
