using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenuController : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Button startButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckStatus()
    {
        if (nameInput.text != "")
        {
            startButton.interactable = true;
        }
        else startButton.interactable = false;
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("playerName", nameInput.text);
        SceneManager.LoadScene(1);
    }

}
