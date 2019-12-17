using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using System;

[Serializable]
public struct CoinComponent : IComponentData
{
    public float speed;
    public int id;
    public float x;
    public float y;
    public float height;
    public float width;
}
