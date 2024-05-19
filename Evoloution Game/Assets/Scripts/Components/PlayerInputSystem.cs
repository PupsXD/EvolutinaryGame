using Leopotam.Ecs;
using UnityEngine;

namespace Components
{
    sealed class PlayerInputSystem : IEcsRunSystem
    {
        
        private readonly EcsWorld _world = null;

        private float _moveX;
        
        private readonly EcsFilter<PlayerTag, InputEventComponent> _inputFilter = null;
        public void Run()
        {
            GetAxis();
            foreach (var i in _inputFilter)
            {
                ref var inputComponent = ref _inputFilter.Get2(i);
                
                ref var direction = ref inputComponent.direction;
                direction.x = _moveX;
            }
        }

        private void GetAxis()
        {
            _moveX = Input.GetAxis("Horizontal");
        }
    }
}