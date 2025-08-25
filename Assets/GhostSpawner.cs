using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.XR.MRUtilityKit; 

public class GhostSpawner : MonoBehaviour
{
    public float spawnTimer = 1;
    public GameObject prefabToSpawn;
    public float minEdgeDistance = 0.3F;
    public MRUKAnchor.SceneLabels spawnLabels;
    public float normalOffset;
    private float timer;
    public int countTries = 1000;
    void Start()
    {
        //
    }

    void Update()
    {
        if (MRUK.Instance == null || !MRUK.Instance.IsInitialized)
            return;

        timer += Time.deltaTime;
        if (timer > spawnTimer)
        {
            SpawnGhost();
            timer -= spawnTimer;
        }
    }

    public void SpawnGhost()
    {
        MRUKRoom room = MRUK.Instance.GetCurrentRoom();


        int currentTry = 0;
        while (currentTry < countTries)
        {
            bool hasFoundPosition = room.GenerateRandomPositionOnSurface(
                 MRUK.SurfaceType.VERTICAL,
                 minEdgeDistance,
                 LabelFilter.Included(spawnLabels),
                 out Vector3 pos,
                 out Vector3 norm
             );
            if (hasFoundPosition)
            {
                Vector3 randomPositionNormalOffset = pos + norm * normalOffset;
                randomPositionNormalOffset.y = 0;
                Instantiate(prefabToSpawn, randomPositionNormalOffset, Quaternion.identity);
                return;
            }
            else
            {
                currentTry++;
            }
        }

          
    }
}