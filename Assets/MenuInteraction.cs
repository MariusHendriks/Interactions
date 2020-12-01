using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteraction : MonoBehaviour
{
    public Material startImg;
    public Material settingsImg;
    public Material exitImg;
    public void setStart()
    {
        //change img to start
        GetComponent<Renderer>().material = startImg;
    }
    public void setSettings()
    {
        // Change img to settings
        GetComponent<Renderer>().material = settingsImg;
    }
    public void setExit()
    {
        // Change img to exit
        GetComponent<Renderer>().material = exitImg;
    }
}
