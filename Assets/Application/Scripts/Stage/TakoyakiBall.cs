using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class TakoyakiBall : MonoBehaviour
{

    static public TakoyakiBall Instantiate(GameObject prefab, Vector3 postion,Transform parent){
        TakoyakiBall obj = Instantiate(prefab, postion, Quaternion.identity,parent).GetComponent<TakoyakiBall>();
        return obj;
    }


    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Hit();
        }
    }

    void Hit()
    {
        var seq = DOTween.Sequence();
    }

    void Death()
    {
        Destroy(this.gameObject);
    }


}
