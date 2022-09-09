using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Leopotam.Ecs;

using Voody.UniLeo;

sealed class PlayerInputSystem : IEcsRunSystem
{
    private readonly EcsFilter<PlayerTag, DirectionComponent> directionFilter = null;

    private float moveX;
    private float moveZ;

    public void Run()
    {
        foreach(var i in directionFilter) 
        {
            ref var directionComponent = ref directionFilter.Get2(i);
            ref var direction = ref directionComponent.Direction;

            direction.x = moveX;
            direction.z = moveZ;
        }
    }

    private void SetDirection() 
    {
        moveZ = Input.GetAxis("Horizontal");
        moveX = -Input.GetAxis("Vertical");
    }
}