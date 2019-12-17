using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class PlayerMovementSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
            var deltaTime = Time.deltaTime;
      

        Entities.ForEach((ref PlayerComponent player, ref Translation translation) =>
        {
            var horizontal = Input.GetAxis("Horizontal") * player.speed;
            var vertical = Input.GetAxis("Vertical") * player.jumpSpeed;

            if (Input.GetKey(KeyCode.RightArrow))
            {

                translation.Value.x += horizontal * Time.deltaTime;
                player.x = translation.Value.x;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                translation.Value.x -= -(horizontal * Time.deltaTime);
                player.x = translation.Value.x;
            }

            else if (Input.GetKey(KeyCode.UpArrow))
            {
                translation.Value.y += vertical*Time.deltaTime;
                player.y = translation.Value.y;
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {
                translation.Value.y -= -(vertical * Time.deltaTime);
                player.y = translation.Value.y;
            }


            //GRAVITY
            //translation.Value.y -= player.gravity * Time.deltaTime;
            //player.y = translation.Value.y;


        });
    }
}



