using UnityEngine;
using System.IO;
using UnityEditor;
public class BuildBundles : Editor
{
    [MenuItem("Assets/Build AssetBundle")]
    static void BuildAssetBundle()
    {
        string assetBundleDirectory ="Assets/AssetBundleExample/AssetBundleData";// @"D:\Users\Aazka Iqbal\Desktop\Data\Data\semesterDATA\aazka(imp)\semester7\unity\EventSystem\EventSystem\Assets\AssetBundleExample
        if (!Directory.Exists(assetBundleDirectory))
        {
            Debug.Log("New Created Directory");
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }
}
