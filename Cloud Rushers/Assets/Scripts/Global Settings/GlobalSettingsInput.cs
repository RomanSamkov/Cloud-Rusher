using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSettingsInput : MonoBehaviour
{
    public LayerMask LevelMask;

    private void Awake()
    {
        GlobalSettings.LevelMask = LevelMask;
    }
}
