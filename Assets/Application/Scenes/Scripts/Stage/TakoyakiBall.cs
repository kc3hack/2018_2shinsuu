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
        if (collision.gameObject.tag == "Obatyan")
        {
            Hit();
        }
    }

    void Hit()
    {
        rigidbody.angularVelocity = Vector3.zero;
        var mat = GetComponent<Renderer>().material;
        var seq = DOTween.Sequence();
        seq.Append(transform.DOScale(Vector3.zero, 0.5f));
        seq.OnComplete(() => Death());

    }

    void Death()
    {
        ObjectPool.instance.ReleaseGameObject(this.gameObject);

    }


}
