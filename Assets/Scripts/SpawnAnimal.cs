using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject objAnimal;
    public Material[] materialAnimal;
    public GameObject canvaObj;
    [SerializeField]
    private int countSpawn = 200;
   

    IEnumerator Spawn()
    {
        int i = 0;
        while(i < countSpawn)
        {
            yield return new WaitForSeconds(.1f);
            var g = Instantiate(objAnimal, transform);
            int ran = Random.Range(0, 2);
            if(ran == 0)
            {
                g.AddComponent<Cat>();
                g.GetComponent<MeshRenderer>().material = materialAnimal[ran];
            }
            else
            {
                g.AddComponent<Dog>();
                g.GetComponent<MeshRenderer>().material = materialAnimal[ran];
            }
            
        }
    }
    public void offCanva()
    {
        canvaObj.SetActive(false);
        StartCoroutine(Spawn());
    }
}
