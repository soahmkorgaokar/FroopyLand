using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class RotatorSystem : ComponentSystem
{

    protected override void OnStartRunning()
    {
       Entities.ForEach((ref CoinComponent coin, ref Translation translation) =>
        {
            translation.Value.x += 4;
            translation.Value.y += 4;
        });
    }


    protected override void OnUpdate()
    {

        //All entities having typeof CoinComponent will rotate 

        Entities.ForEach((ref CoinComponent coin, ref Rotation rotation) =>
        {
           
            {
                rotation.Value = quaternion.Euler(0, 0, coin.speed * (math.PI * Time.realtimeSinceStartup));
            }
        });
    }
}
