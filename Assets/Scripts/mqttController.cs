using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;
using Newtonsoft.Json;

public class mqttController : MonoBehaviour
{
    public string nameController = "Controller 1";
    public mqttReceiver _eventSender;
    public TextMeshProUGUI VELVText;
    public TextMeshProUGUI RAINText;
    public TextMeshProUGUI PRESText;
    public TextMeshProUGUI PV_PRODUCTIONText;
    public TextMeshProUGUI IGROText;
    public TextMeshProUGUI RAFFText;
    public TextMeshProUGUI DIRVText;
    public TextMeshProUGUI RADDText;
    public TextMeshProUGUI TERMText;
    public TextMeshProUGUI timestampText;


    [System.Serializable]
    public class SensorData
    {
        public float VELV;
        public float RAIN;
        public float PRES;
        public float PV_PRODUCTION;
        public float IGRO;
        public float RAFF;
        public float DIRV;
        public float RADD;
        public float TERM;
        public long timestamp;
    }

    void Start()
    {
        _eventSender.OnMessageArrived += OnMessageArrivedHandler;
    }

    private void OnMessageArrivedHandler(string newMsg)
    {
        try
        {
            // Deserialize the JSON message into a SensorData object
            SensorData sensorData = JsonConvert.DeserializeObject<SensorData>(newMsg);
            VELVText.text = "VELV: " + sensorData.VELV.ToString();
            RAINText.text = "RAIN: " + sensorData.RAIN.ToString();
            PRESText.text = "PRES: " + sensorData.PRES.ToString();
            PV_PRODUCTIONText.text = "PV_PRODUCTION: " + sensorData.PV_PRODUCTION.ToString();
            IGROText.text = "IGRO: " + sensorData.IGRO.ToString();
            RAFFText.text = "RAFF: " + sensorData.RAFF.ToString();
            DIRVText.text = "DIRV: " + sensorData.DIRV.ToString();
            RADDText.text = "RADD: " + sensorData.RADD.ToString();
            TERMText.text = "TERM: " + sensorData.TERM.ToString();
            timestampText.text = "timestamp: " + sensorData.timestamp.ToString();

            // Output the values of each index
            Debug.Log("VELV: " + sensorData.VELV);
            Debug.Log("RAIN: " + sensorData.RAIN);
            Debug.Log("PRES: " + sensorData.PRES);
            Debug.Log("PV_PRODUCTION: " + sensorData.PV_PRODUCTION);
            Debug.Log("IGRO: " + sensorData.IGRO);
            Debug.Log("RAFF: " + sensorData.RAFF);
            Debug.Log("DIRV: " + sensorData.DIRV);
            Debug.Log("RADD: " + sensorData.RADD);
            Debug.Log("TERM: " + sensorData.TERM);
            Debug.Log("timestamp: " + sensorData.timestamp);
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error parsing message: " + ex.Message);
        }
    }
}