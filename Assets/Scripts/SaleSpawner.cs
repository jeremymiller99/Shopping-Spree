using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] aisles;
    [SerializeField] private int count;
    
    private int randindex;
    private List<int> aislesInUse = new List<int>();

    void Start()
    {
        count = SaleList.totalItems;
        SpawnSales();
    }

    public void SpawnSales(){
        for (int i = 0; i < count; i++){
            randindex = Random.Range(0, aisles.Length);
            Debug.Log(randindex.ToString());

            if(!aislesInUse.Contains(randindex)){
                aisles[randindex].gameObject.GetComponent<MeshRenderer>().material.color = new Color(0,0,0);
                aisles[randindex].gameObject.GetComponent<Collider>().isTrigger = true;
                aislesInUse.Add(randindex);        
            } else {
                i--;
            }          
        }

    }
}
