using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class botan : MonoBehaviour
{
    public RectTransform contentRectTransform;
    public Button button;
    private void Start()
    {
        string[] obachan;
        obachan = new string[6] {"大阪", "京都", "兵庫","滋賀","和歌山","三重"};
        for (int i = 0; i <= 5; i++)
        {
            var obj = Instantiate(button, contentRectTransform);
            obj.GetComponentInChildren<Text>().text = obachan[i]+"のおばちゃん";
        }
    }
}