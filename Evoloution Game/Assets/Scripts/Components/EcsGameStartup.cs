using System.Collections;
using System.Collections.Generic;
using Components;
using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class EcsGameStartup : MonoBehaviour
{
    private EcsWorld _world = null;
    private EcsSystems _systems;
    void Start()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);
        
        AddSystems();
        AddInjections();
        AddOneFrames();

        _systems.ConvertScene();
        _systems.Init();

        
        
    }
    
    private void Update()
    {
        _systems.Run();
    }

    private void AddSystems()
    {
        _systems.Add(new PlayerInputSystem()).Add(new MovementSystem());
    }
    
    private void AddInjections()
    {
        
    }

    private void AddOneFrames()
    {
        
    }
    
    private void OnDestroy()
    {
        if (_systems != null)
        {
            _systems.Destroy();
            _systems = null;
            _world.Destroy();
            _world = null;
        }
    }
    
    internal struct MovableComponent
    {
        
    }
}
