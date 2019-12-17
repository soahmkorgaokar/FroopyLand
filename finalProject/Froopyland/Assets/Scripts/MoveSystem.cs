using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class MoveSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
    }

    protected override void OnStartRunning()
    {
        Entities.ForEach((ref PlayerComponent player, ref Translation translation) =>
        {
            
            translation.Value.x -= 9;
            translation.Value.y -= 2;
        });
               
    }

}
