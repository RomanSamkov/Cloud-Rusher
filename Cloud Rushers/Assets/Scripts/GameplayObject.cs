using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayObject : MonoBehaviour
{
    public enum ObjectTypes
    {
        flyer,
        projectile
    };

    public ObjectTypes ObjectType;

    public int Health;
    [HideInInspector] public bool Alive = true;

    public virtual void DamageIt()
    {

    }
}
