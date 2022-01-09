using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private void Start()
    {
        StartCoroutine(DoAnimal());
    }
    public Dog() : base("Dog", 500, 4, 3)
    {

    }
   

    public override void Eat()
    {
        _heath += 50;
        Debug.Log(nameGS + "Gau Gau *-* ");
    }





    public override void Jump(float maxHeight)
    {
        if (_heath > 10)
        {
            base.Jump(maxHeight);
            _heath -= 1f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
        
    }

    public override void Jump(Vector3 JumpVector)
    {
        if (_heath > 10)
        {
            base.Jump(JumpVector);
            _heath -= 1f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
       
    }

    public override void Talk()
    {
        Debug.Log("Gau Gau");
    }

   

    public override void Walk()
    {
        if (_heath > 10)
        {
            transform.position += Vector3.forward * (_speed + _speed * 0.5f) * Time.deltaTime;
            _heath -= 0.5f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
        
    }

    public override void Walk(Vector3 direction)
    {
        if (_heath > 10)
        {
            transform.position += direction * (_speed + _speed * 0.5f) * Time.deltaTime;
            _heath -= 0.5f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
        
    }
    IEnumerator DoAnimal()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            int rand = Random.Range(0, 6);

            switch (rand)
            {
                case 0:
                    Eat();
                    break;
                case 1:
                    Jump(4);
                    break;
                case 2:
                    Jump(Vector3.right + Vector3.forward);
                    break;
                case 3:
                    Talk();
                    break;
                case 4:
                    Walk();
                    break;
                case 5:
                    Walk(Vector3.right);
                    break;
                default:
                    break;
            }
        }
    }
}
