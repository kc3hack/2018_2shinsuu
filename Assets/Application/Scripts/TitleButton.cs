using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class TitleButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOShakeScale(0.8f).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainView()
    {
        SceneManager.LoadScene("MainView");
    }
}
