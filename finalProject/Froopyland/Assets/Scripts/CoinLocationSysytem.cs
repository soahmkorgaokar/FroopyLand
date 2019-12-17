using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;


public class CoinLocationSysytem : ComponentSystem
{
    protected override void OnUpdate()
    {

    }


    //POSITIONING ALL THE Coins IN SPACE
    protected override void OnStartRunning()
    {
        Entities.ForEach((ref CoinComponent coin, ref Translation translation) =>
        {   
            

            if (coin.id == 0)
            {
                translation.Value.x -= 4;
                coin.x = translation.Value.x;
                translation.Value.y -= 8f;
                coin.y = translation.Value.y;
            }

            if (coin.id == 1)
            {
                translation.Value.x += 5.5f;
                coin.x = translation.Value.x;
                translation.Value.y -= 5.5f;
                coin.y = translation.Value.y;
            }

            if (coin.id == 2)
            {
                translation.Value.x -= 2.5f;
                coin.x = translation.Value.x;
                translation.Value.y -= 4f;
                coin.y = translation.Value.y;
            }

            if (coin.id == 4)
            {
                translation.Value.x -= 12f;
                coin.x = translation.Value.x;
                translation.Value.y -= 1.5f;
                coin.y = translation.Value.y;
            }
            if (coin.id == 3)
            {
                translation.Value.x += 1f;
                coin.x = translation.Value.x;
                translation.Value.y += 0.5f;
                coin.y = translation.Value.y;
            }
        });

    }
}
