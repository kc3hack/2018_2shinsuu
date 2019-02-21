using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//チュートリアルのコピペ
public class ObjectPool : SingletonMonoBehaviour<ObjectPool>
{
    // ゲームオブジェクトのDictionary
    private Dictionary<int, List<GameObject>> pooledGameObjects = new Dictionary<int, List<GameObject>> ();

    public GameObject parentObj;

    public List<GameObject> GetPoolObjectList(GameObject prefab){
        int key;
        if (prefab.transform.parent == null) {
            // プレハブのインスタンスIDをkeyとする
            key = prefab.GetInstanceID ();
        } else {
            key = prefab.transform.parent.GetInstanceID ();
        }

        // Dictionaryにkeyが存在しなければ作成する
        if (pooledGameObjects.ContainsKey (key) == false) {

            pooledGameObjects.Add (key, new List<GameObject> ());
        }

        return pooledGameObjects [key];

    }


    // ゲームオブジェクトをpooledGameObjectsから取得する。必要であれば新たに生成する
    public GameObject GetGameObject (GameObject prefab, Vector2 position, Quaternion rotation){
        List<GameObject> gameObjects = GetPoolObjectList(prefab);
        GameObject go = null;
        for (int i = 0; i < gameObjects.Count; i++) {
            go = gameObjects [i];
            // 現在非アクティブ（未使用）であれば
            if (go.activeInHierarchy == false) {
                // 位置を設定する
                go.transform.position = position;
                // 角度を設定する
                go.transform.rotation = rotation;
                // これから使用するのでアクティブにする
                go.SetActive (true);
                return go;
            }
        }
        // 使用できるものがないので新たに生成する
        go = (GameObject)Instantiate (prefab, position, rotation, parentObj.transform);
        // ObjectPoolゲームオブジェクトの子要素にする
        //go.transform.parent = parentObj.transform;
        // リストに追加
        gameObjects.Add (go);
        return go;
    }

    public GameObject GetOnlyGameObject (GameObject prefab){
        List<GameObject> gameObjects = GetPoolObjectList(prefab);
        GameObject go = null;
        for (int i = 0; i < gameObjects.Count; i++) {
            go = gameObjects [i];
            if (go.activeInHierarchy == false) {
                return go;
            }
        }
        go = (GameObject)Instantiate (prefab);
        // ObjectPoolゲームオブジェクトの子要素にする
        go.transform.parent = parentObj.transform;
        gameObjects.Add (go);
        return go;
    }


    // ゲームオブジェクトを非アクティブにする。こうすることで再利用可能状態にする
    public void ReleaseGameObject (GameObject go)
    {
        // 非アクティブにする
        go.SetActive (false);
    }
}