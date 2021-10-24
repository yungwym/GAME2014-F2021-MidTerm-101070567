/*
 * Full Name - Robert Alex Wymer 
 * Student ID - 101070567
 * Date Modified - October 24, 2021
 * File - BackgroundController.cs
 * Description - Background Controller, moves background along x-axis to created scrolling background 
 * Revision - v1.0 Initial verison, Horizontal movement and bounds, firing bullets 
 *          - v1.1 - Updated for landscape orientation, changed vertical variables to horizontal
 *                 - Reset() - Resets background along x-axis instead of y-axis
 *                 - Move() - Moves background along x-axis istead of y-axis
 *                 - CheckBounds() - Tests aganist x-position and horizontalBoundary  
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
