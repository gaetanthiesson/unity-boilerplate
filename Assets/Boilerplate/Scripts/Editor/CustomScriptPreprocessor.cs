using UnityEditor;
using System.IO;

public class CustomScriptPreprocessor : AssetModificationProcessor
{
    public static void OnWillCreateAsset(string metaFilePath)
    {
        string fileName = Path.GetFileNameWithoutExtension(metaFilePath);

        if(!fileName.EndsWith(".cs")) return;

        string actualFilePath = $"{Path.GetDirectoryName(metaFilePath)}{Path.DirectorySeparatorChar}{fileName}";

        string content = File.ReadAllText(actualFilePath);

        // Set type in file for CustomEventChannel template
        string type = fileName.Replace("EventChannelSO.cs", "");
        string newContent = content.Replace("#TYPE#", type);

        if(content == newContent) return;

        File.WriteAllText(actualFilePath, newContent);
        AssetDatabase.Refresh();
    }
}
