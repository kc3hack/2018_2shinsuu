using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObatyanListViewModel : SingletonMonoBehaviour<ObatyanListViewModel>
{
    public ObatyanView obatyanPrefab;
    public GameObject obatyanViewContent;
    public ObatyanModel[] obatyans = new ObatyanModel[7];

    private void Start(){
        obatyans[0] = new ObatyanModel();
        obatyans[0].name = "田中 和子（たなか かずこ）";
        obatyans[0].place = "大阪府・大阪市";
        obatyans[0].age = "47歳";
        obatyans[0].description[0] = "ズボンのポッケにはあめちゃんが入っている。味はいちご";
        obatyans[0].description[1] = "飼い犬にもパーマをかけている。名前はマドンナ";
        obatyans[0].description[2] = "服の虎によく話しかけている。名前はこすけ";

        obatyans[1] = new ObatyanModel();
        obatyans[1].name = "沢村 香織（さわむら かおり）";
        obatyans[1].place = "京都府・祇園";
        obatyans[1].age = "？歳";
        obatyans[1].description[0] = "白塗りの下の顔は美人らしい";
        obatyans[1].description[1] = "和傘はUVカットもしてくれる";
        obatyans[1].description[2] = "和食より洋食の方が好き";

        obatyans[2] = new ObatyanModel();
        obatyans[2].name = "北野 典子（きたの ふみこ）";
        obatyans[2].place = "兵庫県・神戸市";
        obatyans[2].age = "44歳";
        obatyans[2].description[0] = "雑誌の下の素顔を見たものはいない";
        obatyans[2].description[1] = "キラキラは針金でつるしている";
        obatyans[2].description[2] = "好きな色は黒";

        obatyans[3] = new ObatyanModel();
        obatyans[3].name = "水津 伊澄（すいず いずみ）";
        obatyans[3].place = "滋賀県・琵琶湖";
        obatyans[3].age = "125歳";
        obatyans[3].description[0] = "琵琶湖の貯水率によってテンションが変わる";
        obatyans[3].description[1] = "最近誰も斧を落としてくれなくて寂しい";
        obatyans[3].description[2] = "金の斧はこれが52代目";

        obatyans[4] = new ObatyanModel();
        obatyans[4].name = "橘 柑菜（たちばな かんな）";
        obatyans[4].place = "和歌山県・紀州";
        obatyans[4].age = "40歳";
        obatyans[4].description[0] = "あたまの上の蜜柑がよく盗難される";
        obatyans[4].description[1] = "好きな食べ物は苺🍓";
        obatyans[4].description[2] = "翼の蜜柑は一週間ごとに取り替える";

        obatyans[5] = new ObatyanModel();
        obatyans[5].name = "伊勢 律子（いせ りつこ）";
        obatyans[5].place = "三重県・伊勢";
        obatyans[5].age = "58歳";
        obatyans[5].description[0] = "この伊勢海老は食べられません";
        obatyans[5].description[1] = "ダンスは律子さんの気分で変わります";
        obatyans[5].description[2] = "目を離すとすぐ休憩する";

        obatyans[6] = new ObatyanModel();
        obatyans[6].name = "末永 佳奈子（すえなが かなこ）";
        obatyans[6].place = "奈良県・東大寺";
        obatyans[6].age = "54歳";
        obatyans[6].description[0] = "子どもの時に被った大仏が抜けないまま大人になった";
        obatyans[6].description[1] = "角は冬になると抜け落ちる";
        obatyans[6].description[2] = "弱点は角";

        CreateObatyanView();
    }

    void CreateObatyanView() {
        foreach (ObatyanModel oba in obatyans) {
            GameObject obj = Instantiate(obatyanPrefab.gameObject, obatyanViewContent.transform, false);
            ObatyanView obatyanView = obj.GetComponent<ObatyanView>();
            obatyanView.obatyan = oba;
            obatyanView.init();
        }
    }

}
