using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaleList : MonoBehaviour
{
    public static int totalItems;
    public static int currentItems;

    private void Start(){
        totalItems = 3;
        currentItems = totalItems;
    }

    public static void RemoveItem(){
        currentItems--;
    }
}
