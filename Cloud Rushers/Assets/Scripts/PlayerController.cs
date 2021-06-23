using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerController : MonoBehaviour
{
    public string Action1Button;
    public string Action2Button;
    public string Action3Button;

    private StandartForwardFlyer flyerSCR;
    private PlayerControlls playerInputs;

    private void Awake()
    {
        playerInputs = new PlayerControlls();
    }

    private void OnEnable()
    {
        playerInputs.Enable();
    }
    private void OnDisable()
    {
        playerInputs.Disable();
    }

    void Start()
    {
        flyerSCR = GetComponent<StandartForwardFlyer>();
    }

    //playerInputs.FlyerInputMap.RotateGoalPercent.ReadValue<Vector2>();
    //playerInputs.FlyerInputMap.WingSweep.triggered;

    void Update()
    {
        var wingAction = playerInputs.FlyerInputMap.WingSweep;

        if (wingAction.triggered)
        {
            flyerSCR.WingSweep();
        }

        var stop = playerInputs.FlyerInputMap.Stop;

        if (((KeyControl)Keyboard.current["S"]).isPressed)
        {
            flyerSCR.AccelerationSpeedPercent = -1;
        }

        if (((KeyControl)Keyboard.current[Action1Button]).isPressed)
        {
            flyerSCR.TryAction1();
        }

        if (((KeyControl)Keyboard.current[Action2Button]).isPressed)
        {
            flyerSCR.TryAction2();
        }

        if (((KeyControl)Keyboard.current[Action3Button]).isPressed)
        {
            flyerSCR.TryAction3();
        }

        //flyerSCR.Action1 = ((KeyControl)Keyboard.current["F"]).isPressed;
    }
}
