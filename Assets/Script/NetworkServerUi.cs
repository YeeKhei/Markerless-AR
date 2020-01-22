using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class NetworkServerUi : MonoBehaviour
{
    private void OnGUI()
    {
        //GUI.Box(new Rect(10, Screen.height - 35, 100, 20), "Status :" + NetworkServer.active);
        //.Box(new Rect(20, Screen.height - 20, 100, 20), "Connected :" + NetworkServer.connections.Count);

    }
    // Start is called before the first frame update
    void Start()
    {
        //NetworkServer.Listen(25000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
