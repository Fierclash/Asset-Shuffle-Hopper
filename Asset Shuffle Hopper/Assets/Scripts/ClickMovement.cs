using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script will allow the player to move an object by
/// clicking on a valid location.
/// </summary>
public class ClickMovement : MonoBehaviour
{
    [Header("Components")]
    public Transform body;          // Game entity to move
    public Transform environment;   // Parent transform containing all the tiles

    void Awake()
    {
        // Load-time Pattern:
        // This is a quick way to gather a large set of references through transform.GetComponent<>()
        // While it is fast for the programmer to implement, it is costly during runtime,
        // so it should only be down during loading screens (e.g. Awake)
        foreach (Transform child in environment)
        {
            var location = child.GetComponent<ClickLocation>();
            location.movement = this;
        }
    }

    /// <summary>
    /// Moves the entity to a specific global position
    /// </summary>
    /// <param name="position"></param>
    public void Move(Vector3 position)
    {
        body.position = position;
    }

}
