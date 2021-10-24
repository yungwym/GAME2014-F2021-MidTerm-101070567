/*
 * Full Name - Robert Alex Wymer 
 * Student ID - 101070567
 * Date Modified - October 24, 2021
 * File - EnemyController.cs
 * Description - Enemy Controller, manages enemy's movement and movement bounds 
 * Revision - v1.0 Initial verison, Horizontal movement and bounds 
 *          - v1.1 - Updated for landscape orientation, changed horizontal variables to vertical 
 *                 - Move() - Moves enemy along the y a-xis instead of x-axis
 *                 - CheckBounds() - Tests aganist enemy's y position and verticalBoundary 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }
        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
