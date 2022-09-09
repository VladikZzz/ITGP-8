using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Leopotam.Ecs;

using Voody.UniLeo;
[System.Serializable]
public struct MovableComponent 
{
    public CharacterController CharacterController;
    public float Speed;
}