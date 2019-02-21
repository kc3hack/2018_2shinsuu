using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ObatyanActor : MonoBehaviour
{
    public string obatyanType;
    public MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnEnable()
    {
        DOVirtual.DelayedCall(30f, () => Death());
        if(StegeObserver.instance.target.CurrentStatus == Vuforia.TrackableBehaviour.Status.NO_POSE)
        {
            renderer.enabled = false;
        }
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
        seq.OnComplete(() => Death());
    }

    void Death()
    {
        ObjectPool.instance.ReleaseGameObject(this.gameObject);
    }
}
