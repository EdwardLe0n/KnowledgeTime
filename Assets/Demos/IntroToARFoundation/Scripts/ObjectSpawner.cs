using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectSpawner : MonoBehaviour
{
    // Reference to the game object we'd want to spawn
    public GameObject objectToSpawn;
    // Ref to the placement indicator object
    private PlacementIndicator placementIndicator;

    // When this game object is created, it will look for any game objects with Placement Indicator and store it
    void Start()
    {
        placementIndicator = FindFirstObjectByType<PlacementIndicator>();
    }

    // Function that creates an object based on the objectToSpawn, that will also use the position
    // and the rotation of the placement indicator
    public void CreateObject()
    {
        GameObject obj = Instantiate(objectToSpawn, 
            placementIndicator.transform.position, placementIndicator.transform.rotation);
    }
    
}