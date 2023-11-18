using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void Quitgame()
    {
        Application.Quit();

        //you can't quit the game inside the inspector
        Debug.Log("LABAS!!!");
    }
}