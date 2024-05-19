using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Components
{
    [Serializable]
    public struct MovableComponent
    {
        public Rigidbody2D rigidbody;
        //public Vector2 direction;
        public float speed;
    }
}