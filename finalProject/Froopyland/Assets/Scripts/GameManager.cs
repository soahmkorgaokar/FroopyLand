using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Collections;

public class GameManager : MonoBehaviour
{
  
    [SerializeField] private Material materialCoin;
    [SerializeField] private Material material2;
    [SerializeField] private Material materialPlatform;

    [SerializeField] private Mesh mesh;

    private EntityManager entityManager;

    private void Start()
    {   
        //ARRAYS TO STORE ENTITIES

        entityManager = World.Active.EntityManager;
        NativeArray<Entity> coinArray = new NativeArray<Entity>(5, Allocator.Temp);
        NativeArray<Entity> playerArray = new NativeArray<Entity>(1, Allocator.Temp);
        NativeArray<Entity> platformArray = new NativeArray<Entity>(15, Allocator.Temp);

        //Archetypes to store components for entity

        EntityArchetype arch = entityManager.CreateArchetype(
            typeof(CoinComponent),
            typeof(RenderMesh),
            typeof(LocalToWorld),
            typeof(Translation),
            typeof(Rotation)
            );


        EntityArchetype arch2 = entityManager.CreateArchetype(
            typeof(PlayerComponent),
            typeof(RenderMesh),
            typeof(LocalToWorld),
            typeof(Translation)            
            );

        EntityArchetype arch3 = entityManager.CreateArchetype(
            typeof(PlatformComponent),
            typeof(RenderMesh),
            typeof(LocalToWorld),
            typeof(Translation),
            typeof(NonUniformScale)
            );

        
        entityManager.CreateEntity(arch2, playerArray);
        entityManager.CreateEntity(arch, coinArray);
        entityManager.CreateEntity(arch3, platformArray);


        int j = 0;
        foreach (Entity entity in coinArray)
        {
            entityManager.SetComponentData(entity, new CoinComponent
            {
                speed = 2,
                 id = j,
                 height=1f,
                 width=1f

            }) ;
            j++;

            entityManager.SetSharedComponentData(entity, new RenderMesh
            {
                mesh = NewMesh(),
                material = materialCoin,
            });

        }
        coinArray.Dispose();


        foreach (Entity entity in playerArray)
        {
            entityManager.SetComponentData(entity, new PlayerComponent
            {
                speed = 6.0f,
                jumpSpeed = 8f,
                gravity = 9.8f,
                height =1f,
                width=1f
              

            });

            entityManager.SetSharedComponentData(entity, new RenderMesh
            {
                mesh = NewMesh(),
                material = material2,
            });

        }
        playerArray.Dispose();

        int i = 0;
        foreach (Entity entity in platformArray)
        {
            entityManager.SetComponentData(entity, new PlatformComponent
            {
                id = i,
                height = 1f,
                width = 3f
            });
            i++;

            entityManager.SetSharedComponentData(entity, new RenderMesh
            {
                mesh = mesh,
                material = materialPlatform,
            });

            entityManager.SetComponentData(entity, new NonUniformScale
            {
                Value = new float3(3f, 1f, 3f),
            });
        }
        platformArray.Dispose();



        Mesh NewMesh()
        {
            Vector3[] vertex = new Vector3[4];
            Vector2[] uv = new Vector2[4];
            int[] triangle = new int[6];

            vertex[0] = new Vector3(-0.5f, -0.5f);
            vertex[1] = new Vector3(-0.5f, +0.5f);
            vertex[2] = new Vector3(+0.5f, +0.5f);
            vertex[3] = new Vector3(+0.5f, -0.5f);

            uv[0] = new Vector2(0, 0);
            uv[1] = new Vector2(0, 1);
            uv[2] = new Vector2(1, 1);
            uv[3] = new Vector2(1, 0);

            triangle[0] = 0;
            triangle[1] = 1;
            triangle[2] = 3;

            triangle[3] = 1;
            triangle[4] = 2;
            triangle[5] = 3;

            Mesh mesh = new Mesh();
            mesh.vertices = vertex;
            mesh.uv = uv;
            mesh.triangles = triangle;

            return mesh;
        }
    }

}


