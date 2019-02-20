using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HoleView : MonoBehaviour{
    public TakoyakiModel takoyaki;
    public Image holeImege;
    public Sprite blank;
    public Sprite rare;
    public Sprite medium;
    public Sprite welldone;

    static public HoleView Instantiate(GameObject prefab, GameObject parent, TakoyakiModel takoyaki) {
        HoleView obj = Instantiate(prefab, parent.transform).GetComponent<HoleView>();
        obj.takoyaki = takoyaki;
        return obj;
    }

    private void Start(){
        takoyaki.ObserveEveryValueChanged(x => x.bakeState)
                .Subscribe(_ => this.ChangeSprite());
    }

    public void ChangeSprite(){
        switch (takoyaki.bakeState) {
            case TakoyakiModel.BakeState.blank:
                holeImege.sprite = blank;
                break;
            case TakoyakiModel.BakeState.rare:
                holeImege.sprite = rare;
                break;
            case TakoyakiModel.BakeState.medium:
                holeImege.sprite = medium;
                break;
            case TakoyakiModel.BakeState.welldone:
                holeImege.sprite = welldone;
                break;
            default:
                break;
         }
    }

    public void EkiDropEvent(){
        TakoyakiViewModel.instance.IntoTakoyakiEki(this.takoyaki);
    }

}
