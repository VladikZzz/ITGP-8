using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Leopotam.Ecs;

using Voody.UniLeo;

public sealed class EcsController : MonoBehaviour
{
    private EcsWorld world;
    private EcsSystems systems;

    private void Start() 
    {
        world = new EcsWorld();
        systems = new EcsSystems(world);
        systems.ConvertScene();

        AddInjection();
        AddSystem();
        AddOneFrames();
        systems.Init();
    }

    private void Update() 
    {
        systems.Run();
    }

    private void OnDestroy() 
    {
        systems.Destroy();
        systems = null;
        world.Destroy();
        world = null;
    }
    private void AddInjection()
    {
    }
    private void AddSystem()
    {
        systems.Add(new PlayerInputSystem()).Add(new MovementSystem());
    }
    private void AddOneFrames()
    {
    }
    
}