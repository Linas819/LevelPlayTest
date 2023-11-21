using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Log : MonoBehaviour
{
    string LogText;
    public TextMeshProUGUI LogTextGUI;
    public GameObject Buttons, LogView;
    // Start is called before the first frame update
    void Start()
    {
        LogText = "";
        LogTextGUI.SetText(LogText);
        LogView.SetActive(false);
    }

    public void UpdateLogText(string logText)
    {
        LogText += logText;
        LogTextGUI.SetText(LogText);
    }

    public void EnableLog()
    {
        Buttons.SetActive(false);
        LogView.SetActive(true);
    }

    public void EnableButtons()
    {
        LogView.SetActive(false);
        Buttons.SetActive(true);
    }
}
