using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace FrameSynthesis
{
    public class UnityTools
    {
        const string ForkPath = "C:\\Users\\katsuomi\\AppData\\Local\\Fork\\Fork.exe";

        [MenuItem("Frame Synthesis/Open Fork")]
        public static void OpenFork()
        {
            Process.Start(ForkPath, Directory.GetParent(Application.dataPath).FullName);
        }
    }
}
