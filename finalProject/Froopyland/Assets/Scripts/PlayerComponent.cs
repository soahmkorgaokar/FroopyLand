using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using System;

[Serializable]
public struct PlayerComponent : IComponentData
{
    //public float moveInput;
    public float speed;
    public float jumpSpeed;
    public float gravity;
    public float x;
    public float y;
    public float height;
    public float width;
   
}

 