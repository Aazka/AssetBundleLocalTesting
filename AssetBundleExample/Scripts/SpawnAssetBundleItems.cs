using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SpawnAssetBundleItems : MonoBehaviour
{
    AssetBundle mybundle;
    public string path,loadedItemName;
    private void Start()
    {
        LoadData(path);
        InitBundle();
    }
    void LoadData(string urlPath)// we are loading data from file, if we load data from memory we use async method
    {
        mybundle = AssetBundle.LoadFromFile(urlPath);
        Debug.Log(mybundle == null ? "Failed To Load Bundle" : "Bundle loaded successfully");
    }
    void InitBundle()
    {
        var prefab = mybundle.LoadAsset<GameObject>(loadedItemName);
        Instantiate(prefab);
    }
}
