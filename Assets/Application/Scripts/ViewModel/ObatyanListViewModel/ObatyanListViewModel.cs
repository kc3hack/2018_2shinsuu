using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObatyanListViewModel : SingletonMonoBehaviour<ObatyanListViewModel>
{
    public ObatyanView obatyanPrefab;
    public setsumei obatyanCellPrefab;
    public GameObject obatyanViewContent;
    public GameObject obatyanListViewContent;
    public ObatyanModel[] obatyans;

    private void Start(){
        obatyans = ObatyanModel.obatyans;

        CreateObatyanView();
        CreateObatyanListViewCell();
    }

    void CreateObatyanListViewCell(){
        foreach (ObatyanModel oba in obatyans)
        {
            GameObject obj = Instantiate(obatyanCellPrefab.gameObject, obatyanListViewContent.transform, false);
            setsumei se = obj.GetComponent<setsumei>();
            se.obatyan = oba;
            se.init();
        }
    }

    void CreateObatyanView() {
        /*foreach (ObatyanModel oba in obatyans) {
            GameObject obj = Instantiate(obatyanPrefab.gameObject, obatyanViewContent.transform, false);
            ObatyanView obatyanView = obj.GetComponent<ObatyanView>();
            obatyanView.obatyan = oba;
            obatyanView.init();
        }*/
    }

    public void OpenObatyanView(ObatyanModel obatyan)
    {
        GameObject obj = Instantiate(obatyanPrefab.gameObject, obatyanViewContent.transform, false);
        ObatyanView obatyanView = obj.GetComponent<ObatyanView>();
        obatyanView.obatyan = obatyan;
        obatyanView.init();
    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainView");
    }
}
