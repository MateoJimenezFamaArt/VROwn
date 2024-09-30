using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    // A dictionary to store the original positions of the game objects
    private Dictionary<GameObject, Vector3> originalPositions = new Dictionary<GameObject, Vector3>();

    // List of game objects to reset
    public List<GameObject> gameObjectsToReset;

    void Start()
    {
        // Store the original positions of all game objects in the list
        foreach (GameObject obj in gameObjectsToReset)
        {
            if (obj != null)
            {
                originalPositions[obj] = obj.transform.position;
            }
        }
    }

    // Method to reset the game objects' positions
    public void ResetObjectsToOriginalPositions()
    {
        foreach (GameObject obj in gameObjectsToReset)
        {
            if (obj != null && originalPositions.ContainsKey(obj))
            {
                obj.transform.position = originalPositions[obj];
            }
        }
    }
}
