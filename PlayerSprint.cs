using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSprint : MonoBehaviour
{
    public float totalStamina;
    public float stamina;

    void Awake()
    {
        stamina = totalStamina;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            PlayerController.isRunning = true;
            stamina -= 0.3f;
        }
        else
        {
            PlayerController.isRunning = false;
        }
        if (stamina < 100 && !Input.GetKey(KeyCode.LeftShift))
        {
            stamina += 0.3f;
        }
    }
}
