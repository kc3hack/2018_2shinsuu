using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObayanManager : SingletonMonoBehaviour<ObayanManager>{
    public GameObject obatyanPrefab;

    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.DelayedCall(2f, () => PopObatyan()).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PopObatyan() {
        Vector3 popPoint = new Vector3(Random.Range(-10.0f, 10.0f), 0.5f, Random.Range(-10.0f, 10.0f));
        var obj = ObjectPool.instance.GetGameObject(obatyanPrefab, new Vector3(0 ,0.5f,0),Quaternion.identity);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localRotation = Quaternion.identity;
        //obj.transform.LookAt(Camera.main.transform);
    }
}
