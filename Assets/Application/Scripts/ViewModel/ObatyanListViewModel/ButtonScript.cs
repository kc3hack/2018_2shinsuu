using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonScript : MonoBehaviour
{
    public GameObject GoalText;
    public void ButtonPush()
    {
        Debug.Log("Button Push !!");
    }

    public Sprite _on;
    public Sprite _off;
    private bool flg = true;

    public void changeImage()
    {
        var img = GetComponent<Image>();
        img.sprite = (flg) ? _on : _off;
        flg = !flg;
    }

    public void Touch()
    {
        gameObject.SetActive(true);
    }


}
