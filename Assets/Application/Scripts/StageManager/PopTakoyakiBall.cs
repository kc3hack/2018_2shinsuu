using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopTakoyakiBall : SingletonMonoBehaviour<PopTakoyakiBall>{

    public TakoyakiBall takoyakiBallPrefab;
    public GameObject imageTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shot(Vector3 acceleration)
    {
        Debug.Log(acceleration);
        var ball = TakoyakiBall.Instantiate(takoyakiBallPrefab.gameObject, Camera.main.transform.position, imageTarget.transform);
        acceleration.z = 100;
        float speed = 100000;
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1,1,1)).normalized;
        Vector3 velocity = cameraForward * speed;
        ball.rigidbody.AddForce(velocity);


    }
}
