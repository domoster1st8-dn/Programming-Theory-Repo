using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITANCE
{
    public Cat() : base("Cat", 300, 6, 6)
    {
    }

    private void Start()
    {
        StartCoroutine(DoAnimal());
    }

    public override void Eat() //POLYMORPHISM
    {
        _heath += 20f;
        Debug.Log(nameGS + "Meo Meo *-* ");
    }
    public override void Talk() //POLYMORPHISM
    {
        Debug.Log("Meo Meo");
    }
    
    public override void Walk(Vector3 direction) //POLYMORPHISM
    {
        if (CheckHeath(10))
        {
            base.Walk(direction);
            _heath -= 10f;
        }
        else
            Debug.Log(nameGS + "hurry ^-^");
    }
    public override void Jump(float maxHeight) //POLYMORPHISM
    {
        
        if (CheckHeath(5))
        {
            _heath -= 5f;
            base.Jump(maxHeight + (maxHeight * 0.5f));
        }
        else
            Debug.Log(nameGS + "hurry ^-^");
    }

    public override void Jump(Vector3 JumpVector) //POLYMORPHISM
    {
        if (CheckHeath(5))
        {
            _heath -= 5f;
            base.Jump(JumpVector);
        }
        else
            Debug.Log(nameGS + "hurry ^-^");
        
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
                    Jump(Vector3.left + Vector3.forward);
                    break;
                case 3:
                    Talk();
                    break;
                case 4:
                    Walk();
                    break;
                case 5:
                    Walk(Vector3.down);
                    break;
                default:
                    break;
            }
        }
    }
}
