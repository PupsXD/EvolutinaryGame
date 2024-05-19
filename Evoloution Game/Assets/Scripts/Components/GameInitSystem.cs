using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;

public class GameInitSystem : IEcsInitSystem
{
    EcsWorld _world = null;
    
    public void Init()
    {
        var player = _world.NewEntity();
        //player.Set<MovableComponent>();
    }
}
