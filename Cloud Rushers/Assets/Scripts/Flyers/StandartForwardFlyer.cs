using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartForwardFlyer : GameplayObject
{
    //Flayer is a parent class for all organic flyers like pegasus, changeling and griffon

    public enum RaceTypes
    {
        pegasus,
        changeling
    };

    public RaceTypes Race;

    public Transform Vertical;
    public Transform Body;

    public float AccelerationSpeed;
    public float CurrentSpeed;
    public float MinSpeed;
    public float MaxSpeed;

    public float AccelerationRotSpeed;
    public float CurrentRotSpeed;
    public float GoalRotSpeed;
    public float MaxRotSpeed;

    //Inputs from Player Controller or AI
    [HideInInspector] public float AccelerationSpeedPercent;
    [HideInInspector] public float HorizontalRotateSpeedPercent;
    [HideInInspector] public float VerticalRotateSpeedPercent;

    private float currentWingSweepTime = 0;
    private float timeToSaveSpeed = 4f;
    private float timeToAccelerate = 2f;
    private float chaosTime = 1f;

    public enum WingSweepStatuses
    {
        Chaos,
        Acceleration,
        SaveSpeed,
        SlowDown
    };

    public WingSweepStatuses WingSweepStatus = WingSweepStatuses.SlowDown;

    public void WingSweep()
    {
        if (currentWingSweepTime < chaosTime)
        {
            WingSweepStatus = WingSweepStatuses.Chaos;
        }
        else if (currentWingSweepTime < timeToAccelerate)
        {
            WingSweepStatus = WingSweepStatuses.Acceleration;
        }
        else if (currentWingSweepTime < timeToSaveSpeed)
        {
            WingSweepStatus = WingSweepStatuses.SaveSpeed;
        }
        else
        {
            WingSweepStatus = WingSweepStatuses.SlowDown;
        }

        

        currentWingSweepTime = 0;
    }

    private void Update()
    {
        currentWingSweepTime++;

        if(WingSweepStatus == WingSweepStatuses.Chaos)
        {
            Debug.Log("Acceleration speed is -0.5");
        }
        if (WingSweepStatus == WingSweepStatuses.Acceleration)
        {
            Debug.Log("Acceleration speed is 1");
        }
        if (WingSweepStatus == WingSweepStatuses.SaveSpeed)
        {
            Debug.Log("Acceleration speed is 0");
        }
        if (WingSweepStatus == WingSweepStatuses.SlowDown)
        {
            Debug.Log("Acceleration speed is -0.3");
        }
    }

    public void TryIncreaseAccelerationSpeed()
    {

    }

    public void TryDecreaseAccelerationSpeed()
    {

    }

    public void TryAction1()
    {

    }

    public void TryAction2()
    {

    }

    public void TryAction3()
    {

    }
}
