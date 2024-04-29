using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    [SerializeField] private float knockbackForce;

    private void OnCollisionEnter(Collision col){
        Rigidbody colrb = col.collider.GetComponent<Rigidbody>();
        if (colrb != null){
            Vector3 direction = col.transform.position - transform.position;
            direction.y = Mathf.Abs(direction.y);

            colrb.AddForce(direction.normalized * knockbackForce, ForceMode.VelocityChange);
        }
    }

    private void OnTriggerEnter(Collider col){
        SaleList.RemoveItem();
    }
}
