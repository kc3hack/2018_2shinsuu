using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObatyanModel{
    private static ObatyanModel[] _obatyans;
    public static ObatyanModel[] obatyans { get { if (_obatyans == null) SetModel(); return _obatyans; } }

    public static void SetModel()
    {
        _obatyans = new ObatyanModel[7];

        _obatyans[0] = new ObatyanModel();
        _obatyans[0].name = "田中 和子（たなか かずこ）";
        _obatyans[0].place = "大阪府・大阪市";
        _obatyans[0].age = "47歳";
        _obatyans[0].description[0] = "ズボンのポッケにはあめちゃんが入っている。味はいちご";
        _obatyans[0].description[1] = "飼い犬にもパーマをかけている。名前はマドンナ";
        _obatyans[0].description[2] = "服の虎によく話しかけている。名前はこすけ";
        _obatyans[0].spritePath = "Images/obatyans/osaka";

        _obatyans[1] = new ObatyanModel();
        _obatyans[1].name = "沢村 香織（さわむら かおり）";
        _obatyans[1].place = "京都府・祇園";
        _obatyans[1].age = "？歳";
        _obatyans[1].description[0] = "白塗りの下の顔は美人らしい";
        _obatyans[1].description[1] = "和傘はUVカットもしてくれる";
        _obatyans[1].description[2] = "和食より洋食の方が好き";
        _obatyans[1].spritePath = "Images/obatyans/kyoto";

        _obatyans[2] = new ObatyanModel();
        _obatyans[2].name = "北野 典子（きたの ふみこ）";
        _obatyans[2].place = "兵庫県・神戸市";
        _obatyans[2].age = "44歳";
        _obatyans[2].description[0] = "雑誌の下の素顔を見たものはいない";
        _obatyans[2].description[1] = "キラキラは針金でつるしている";
        _obatyans[2].description[2] = "好きな色は黒";
        _obatyans[2].spritePath = "Images/obatyans/hyogo";

        _obatyans[3] = new ObatyanModel();
        _obatyans[3].name = "水津 伊澄（すいず いずみ）";
        _obatyans[3].place = "滋賀県・琵琶湖";
        _obatyans[3].age = "125歳";
        _obatyans[3].description[0] = "琵琶湖の貯水率によってテンションが変わる";
        _obatyans[3].description[1] = "最近誰も斧を落としてくれなくて寂しい";
        _obatyans[3].description[2] = "金の斧はこれが52代目";
        _obatyans[3].spritePath = "Images/obatyans/siga";

        _obatyans[4] = new ObatyanModel();
        _obatyans[4].name = "橘 柑菜（たちばな かんな）";
        _obatyans[4].place = "和歌山県・紀州";
        _obatyans[4].age = "40歳";
        _obatyans[4].description[0] = "あたまの上の蜜柑がよく盗難される";
        _obatyans[4].description[1] = "好きな食べ物は苺🍓";
        _obatyans[4].description[2] = "翼の蜜柑は一週間ごとに取り替える";
        _obatyans[4].spritePath = "Images/obatyans/wakayama";

        _obatyans[5] = new ObatyanModel();
        _obatyans[5].name = "伊勢 律子（いせ りつこ）";
        _obatyans[5].place = "三重県・伊勢";
        _obatyans[5].age = "58歳";
        _obatyans[5].description[0] = "この伊勢海老は食べられません";
        _obatyans[5].description[1] = "ダンスは律子さんの気分で変わります";
        _obatyans[5].description[2] = "目を離すとすぐ休憩する";
        _obatyans[5].spritePath = "Images/obatyans/mie";

        _obatyans[6] = new ObatyanModel();
        _obatyans[6].name = "末永 佳奈子（すえなが かなこ）";
        _obatyans[6].place = "奈良県・東大寺";
        _obatyans[6].age = "54歳";
        _obatyans[6].description[0] = "子どもの時に被った大仏が抜けないまま大人になった";
        _obatyans[6].description[1] = "角は冬になると抜け落ちる";
        _obatyans[6].description[2] = "弱点は角";
        _obatyans[6].spritePath = "Images/obatyans/nara";
    }

    public string name;
    public string place;
    public string age;
    public string[] description = new string[4];
    public int getCount;
    public string spritePath;
}
