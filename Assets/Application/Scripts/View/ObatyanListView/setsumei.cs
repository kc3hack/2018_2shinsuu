using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setsumei : MonoBehaviour
{
    public ObatyanModel obatyan;
    public Image icon;
    public Text place;
    private void Start()
    {
        this.init();
    }

    public void init()
    {
        this.icon.sprite = Resources.Load<Sprite>(obatyan.spritePath);
        this.place.text = obatyan.place;

    }

    public void Taped()
    {
        ObatyanListViewModel.instance.OpenObatyanView(this.obatyan);
    }
}