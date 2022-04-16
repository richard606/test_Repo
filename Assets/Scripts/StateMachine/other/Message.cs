using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI message_Tmp;
    [SerializeField] GameObject message_Pnl;

    public static Message instance;

    private void Start()
    {
        instance = this;
    }

    public void ShowMessageDialog(string message)
    {

        message_Tmp.text = message;
        message_Pnl.SetActive(true);

    }


}
