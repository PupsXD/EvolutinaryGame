using Leopotam.Ecs;
using UnityEngine;

namespace Components
{
    sealed class MovementSystem : IEcsRunSystem
    {
        
        private readonly EcsWorld _world = null;
        
        private readonly EcsFilter<ModelComponent, MovableComponent, InputEventComponent> _movableFilter = null;

        public void Run()
        {
            foreach (var i in _movableFilter)
            {
                ref var modelComponent = ref _movableFilter.Get1(i);
                ref var movableComponent = ref _movableFilter.Get2(i);
                ref var inputComponent = ref _movableFilter.Get3(i);
                
                ref var direction = ref inputComponent.direction;
                ref var transform = ref modelComponent.modelTransform;
                
                //var rawVector = new Vector2(direction.x, 0f);
                ref var speed = ref movableComponent.speed;
                var force = new Vector2(direction.x, 0f) * speed;
                movableComponent.rigidbody.velocity = force;
            }
        }
    }
}