/*
 * Full Name - Robert Alex Wymer 
 * Student ID - 101070567
 * Date Modified - October 24, 2021
 * File - BulletController.cs
 * Description - Bullet Controller, manages bullets movement, bounds and damage  
 * Revision - v1.0 Initial verison, vertical movement  
 *          - v1.1 - Updated for landscape orientation, changed vertical to horizontal movement 
 *                 - Move() - Updated vertical to horizintal movement along the bullets x axis
 *                 - CheckBounds() - Tests aganist bullets x position and horizontal Boundary
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horiztonalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horiztonalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
