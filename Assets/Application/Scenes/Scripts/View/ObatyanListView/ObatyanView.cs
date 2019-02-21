using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObatyanView : MonoBehaviour
{
    public ObatyanModel obatyan;

    public Text name;
    public Image image;
    public Text getCountText;
    public Text place;
    public Text age;
    public Text[] discription;


    public void init() {
        this.name.text = obatyan.name;
        this.age.text = obatyan.age;
        this.place.text = obatyan.place;
        this.discription[0].text = obatyan.description[0];
        this.discription[0].text = obatyan.description[1];
        this.discription[0].text = obatyan.description[2];
    }
}
