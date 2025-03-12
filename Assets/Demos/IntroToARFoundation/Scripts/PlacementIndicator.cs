using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class PlacementIndicator : MonoBehaviour
{
    // Will hold a reference to the 
    private ARRaycastManager rayManager;
    // This is a reference to the child game object that holds visual elements!
    public GameObject visual;
    
    // When the game object attached to this script is first run, this func will be called!
    void Start ()
    {
        
        // get the components
        rayManager = FindFirstObjectByType<ARRaycastManager>();
        
        // hides the placement visual to start out
        visual.SetActive(false);
        
    }
    void Update ()
    {
        // --- 
        
        // shoot a raycast from the center of the screen
        
        // First makes a list of ARRaycastHit type
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        
        // then tells the Ray Manager to cast a ray (a really thin line) from the position of the middle of the screen to the world
        // those hits are then saved into the hits list made previously!
        // Also by specifying TrackableType.Planes, we are letting the engine know that we're looking for any sort of plane!
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
        
        // --- 
        
        // if we hit an AR plane, update the position and rotation
        if(hits.Count > 0)
        {
            // updates the position of the transform to the position of the collision
            transform.position = hits[0].pose.position;
            
            // updates the rotation of the transform to the rotation of the collision
            transform.rotation = hits[0].pose.rotation;
            
            // Then is it's not active, the visual of the game object will be set to active!
            if(!visual.activeInHierarchy)
                visual.SetActive(true);
        }
    }
}