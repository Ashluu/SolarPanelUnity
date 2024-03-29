using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mqttController : MonoBehaviour
{
    public string nameController = "Controller 1";

    public mqttReceiver _eventSender;

    void Start()
    {
        _eventSender.OnMessageArrived += OnMessageArrivedHandler;
    }

    private void OnMessageArrivedHandler(string newMsg)
    {
        this.GetComponent<TextMeshPro>().text = newMsg;
        Debug.Log("Event Fired. The message, from Object " + nameController + " is = " + newMsg);
    }

}