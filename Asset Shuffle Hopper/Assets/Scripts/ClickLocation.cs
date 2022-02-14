using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script should be put on objects that the player
/// can be able to move to.
/// </summary>
public class ClickLocation : MonoBehaviour
{
    [Header("Components")]
    public ClickMovement movement;

    /// <summary>
    /// This is called whenever the mouse clicks on this tile.
    /// Must have a collider to work.
    /// </summary>
    void OnMouseDown()
    {
        movement.Move(transform.position);
    }
}
