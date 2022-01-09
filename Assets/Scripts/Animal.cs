using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private string _name;
    private float heath;
    private float speed;
    private float jumpForce;

    public string nameGS
    {
        get => _name;
        set
        {
            if (!value.Equals("") && value.Length < 15)
            {
                _name = value;
            }
        }
    }
    public float _heath
    {
        get => heath;
        set
        {
            if (value < 5000 && value > -10)
            {
                heath = value;
            }
        }
    }
    public float _speed
    {
        get => speed;
        set
        {
            if (value >= 0)
                speed = value;
        }
    }

    public float _jumpForce { 
        get => jumpForce; 
        set {
            if (value >= 0)
                jumpForce = value;
        } 
    }
    public Animal(string name,float heath,float speed,float jump)
    {
        _name = name;
        this.heath = heath;
        this.speed = speed;
        jumpForce = jump;
    }
    public Rigidbody r2 { get; private set; }

    private void Awake()
    {
        r2 = GetComponent<Rigidbody>();
    }

    public virtual void Walk()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
    public virtual void Walk(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    public virtual void Eat()
    {
        heath += 10f;
    }
    public virtual void Jump(float maxHeight)
    {
        r2.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        if (r2.velocity.y > maxHeight)
        {
            r2.velocity = new Vector3(r2.velocity.x, maxHeight, r2.velocity.z);
        }
    }

    public virtual void Jump(Vector3 JumpVector)
    {
        r2.AddForce(jumpForce * JumpVector, ForceMode.Impulse);
    }
    public virtual void Talk()
    {
        Debug.Log("Animal Alo ALo ~ Hello World ");
    }

}
