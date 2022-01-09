using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITANCE
{
    private void Start()
    {
        StartCoroutine(DoAnimal());
    }
    public Dog() : base("Dog", 500, 4, 3)
    {

    }
   

    public override void Eat() //POLYMORPHISM
    {
        _heath += 50;
        Debug.Log(nameGS + "Gau Gau *-* ");
    }





    public override void Jump(float maxHeight) //POLYMORPHISM
    {
        if (CheckHeath(10))
        {
            base.Jump(maxHeight);
            _heath -= 10f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
        
    }

    public override void Jump(Vector3 JumpVector) //POLYMORPHISM
    {
        if (CheckHeath(10))
        {
            base.Jump(JumpVector);
            _heath -= 10f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
       
    }

    public override void Talk() //POLYMORPHISM
    {
        Debug.Log("Gau Gau");
    }

   

    public override void Walk() //POLYMORPHISM
    {
        if (CheckHeath(10))
        {
            transform.position += Vector3.forward * (_speed + _speed * 0.5f) * Time.deltaTime;
            _heath -= 10f;
        }
        else
            Debug.Log(nameGS + "Gau Gau ^-^");
        
    }

    public override void Walk(Vector3 direction) //POLYMORPHISM
    {
        if (CheckHeath(10))
        {
            transform.position += direction * (_speed + _speed * 0.5f) * Time.deltaTime;
            _heath -= 10f;
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
