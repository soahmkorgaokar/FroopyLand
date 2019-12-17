using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class PlatformLocationSystem : ComponentSystem
{
    protected override void OnUpdate()
    {

    }
    
    //POSITIONING ALL THE PLATFORMS IN SPACE
    protected override void OnStartRunning()
    {
        Entities.ForEach((ref PlatformComponent platform, ref Translation translation) =>
        {
            if (platform.id == 1)
            {
                translation.Value.x -= 6;
                platform.x = translation.Value.x;
                translation.Value.y -= 5;
                platform.y = translation.Value.y;
            }


            if(platform.id == 2)
            {
                translation.Value.x -= 0;
                platform.x = translation.Value.x;
                translation.Value.y -= 5;
                platform.y = translation.Value.y;
            }

            if (platform.id == 3)
            {
                translation.Value.x += 6;
                platform.x = translation.Value.x;
                translation.Value.y -= 5;
                platform.y = translation.Value.y;
            }

            if (platform.id == 4)
            {
                translation.Value.x += 10;
                platform.x = translation.Value.x;
                translation.Value.y -= 2.5f;
                platform.y = translation.Value.y;
            }

            if (platform.id == 5)
            {
                translation.Value.x -= 9;
                platform.x = translation.Value.x;
                translation.Value.y -= 5;
                platform.y = translation.Value.y;
            }

            if (platform.id == 0)
            {
                translation.Value.x -= 3;
                platform.x = translation.Value.x;
                translation.Value.y = 0;
                platform.y = translation.Value.y;
            }

            if (platform.id == 6)
            {
                translation.Value.x += 6;
                platform.x = translation.Value.x;
                translation.Value.y -= 0;
                platform.y = translation.Value.y;
            }

            if(platform.id == 7)
            {
                translation.Value.x +=1.5f;
                platform.x = translation.Value.x;
                translation.Value.y -= 1;
                platform.y = translation.Value.y;
            }


            if (platform.id == 8)
            {
                translation.Value.x -= 0;
                platform.x = translation.Value.x;
                translation.Value.y -= 5;
                platform.y = translation.Value.y;
            }

            if (platform.id == 9)
            {
                translation.Value.x -= 8f;
                platform.x = translation.Value.x;
                translation.Value.y += 1.5f;
                platform.y = translation.Value.y;
            }

            if (platform.id == 10)
            {
                translation.Value.x -= 11;
                platform.x = translation.Value.x;
                translation.Value.y += 1.5f;
                platform.y = translation.Value.y;
            }


            if (platform.id == 11)
            {
                translation.Value.x -= 3.5f;
                platform.x = translation.Value.x;
                translation.Value.y += 3.5f;
                platform.y = translation.Value.y;
            }

            if (platform.id == 12)
            {
                translation.Value.x -= 0.5f;
                platform.x = translation.Value.x;
                translation.Value.y += 3.5f;
                platform.y = translation.Value.y;
            }

            if (platform.id == 13)
            {
                translation.Value.x += 5;
                platform.x = translation.Value.x;
                translation.Value.y += 3.5f;
                platform.y = translation.Value.y;
            }

            if (platform.id == 14)
            {
                translation.Value.x += 10;
                platform.x = translation.Value.x;
                translation.Value.y += 3.5f;
                platform.y = translation.Value.y;
            }
        });

    }
}
