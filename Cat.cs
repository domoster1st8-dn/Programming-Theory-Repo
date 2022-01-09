using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private void Update()
    {
       
    }

    public override void Eat()
    {
        _heath += 20f;
    }
    public override void Talk()
    {
        Debug.Log("Meo Meo");
    }
    
    public override void Walk(Vector3 direction)
    {
        if (_heath > 10)
        {
            base.Walk(direction);
            _heath -= 0.1f;
        }
        else
            Debug.Log(name +"hurry ^-^");
    }
}
