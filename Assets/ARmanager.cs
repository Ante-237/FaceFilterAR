using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ARmanager : MonoBehaviour
{
    public Button HintBtn;
    public TextMeshProUGUI TextMesh;
    public List<string> textList = new List<string>() {  "Success", "Failure", "Good Day", "Swimming"};

    public GameObject EntryMenu;
    public Button StartBtn;

    public void Start()
    {
        HintBtn.onClick.AddListener(UpdateStatus);
        StartBtn.onClick.AddListener(HideEntryPanel);
    }

    public void UpdateStatus()
    {
        TextMesh.text = textList[Random.Range(0, textList.Count)];
    }

    public void HideEntryPanel()
    {
        EntryMenu.SetActive(false);
    }




}
