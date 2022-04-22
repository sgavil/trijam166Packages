using UnityEditor;
using UnityEngine;
using System.IO;


namespace trijam166
{
    public static class ToolsMenu 
    {
        [MenuItem("Tools/Setup/Create default folders")]
        public static void CreateDefaultFolders(){
            Dir("Project", "Scripts", "Art", "Scenes");
            AssetDatabase.Refresh();
        }

        public static void Dir(string root, params string []dir ){
            var fullPath = Path.Combine(Application.dataPath, root);
            foreach( var newDirectory in dir){
                Directory.CreateDirectory(Path.Combine(fullPath,newDirectory));
            }
        }
    }
}
