using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ObatyanActor : MonoBehaviour
{
    public int HP = 1;

    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.DelayedCall(30f, () => Death());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), Random.Range(-5.0f, 5.0f));
        this.transform.Translate(transform.forward * 0.5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball") {
            Hit();
         }
    }

    void Hit()
    {
        var seq = DOTween.Sequence();
        var mat = GetComponent<Renderer>().material;
        seq.Append(transform.DOScale(Vector3.zero, 3f).SetEase(Ease.OutElastic));
        seq.Append(mat.DOColor(new Color(1,1,1,0), 3f));
        seq.OnComplete(() => Death());
    }

    void Death()
    {
        ObjectPool.instance.ReleaseGameObject(this.gameObject);
    }
}
