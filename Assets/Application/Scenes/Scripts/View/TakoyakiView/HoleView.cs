using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HoleView : MonoBehaviour{
    public TakoyakiModel takoyaki;
    public DropAttribute dropAttribute;
    public FlickAttrubute flickAttrubute;
    public Image holeImege;
    public Image takoImage;
    public Sprite blank;
    public Sprite rare;
    public Sprite medium;
    public Sprite welldone;

    public Sprite tako;
    public Sprite takoIn;

    static public HoleView Instantiate(GameObject prefab, GameObject parent, TakoyakiModel takoyaki) {
        HoleView obj = Instantiate(prefab, parent.transform).GetComponent<HoleView>();
        obj.takoyaki = takoyaki;
        return obj;
    }

    private void Start(){
        takoyaki.ObserveEveryValueChanged(x => x.bakeState)
                .Subscribe(_ => this.refresh());

        takoyaki.ObserveEveryValueChanged(x => x.isInTako)
                .Subscribe(_ => this.refresh());

        dropAttribute.dropEventSubject.Subscribe(DropEvent);
        flickAttrubute.flickEventSubject.Subscribe(FlickEvent);
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

    public void refresh()
    {
        switch (takoyaki.bakeState)
        {
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
        if(takoyaki.bakeState != TakoyakiModel.BakeState.blank)
        {
            takoImage.sprite = takoIn;
        }
        else
        {
            takoImage.sprite = tako;
        }
        takoImage.enabled = takoyaki.isInTako;
    }

    public void ChengeInTako() {
        takoImage.enabled = takoyaki.isInTako;
     }

    public void DropEvent(GameObject obj){
        if (obj.tag == "Eki") {
            TakoyakiViewModel.instance.IntoTakoyakiEki(this.takoyaki);
        }
        else if(obj.tag == "Tako")
        {
            TakoyakiViewModel.instance.IntoTako(this.takoyaki);
        }
    }

    public void FlickEvent(Vector3 acceleration){
        TakoyakiViewModel.instance.Shot(acceleration, this.takoyaki);
    }
}
