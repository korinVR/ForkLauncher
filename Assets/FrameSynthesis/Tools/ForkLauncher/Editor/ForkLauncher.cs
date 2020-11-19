using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace FrameSynthesis.Tools
{
    public class ForkLauncher
    {
        [MenuItem("Fork/Launch Fork")]
        public static void OpenFork()
        {
            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var forkPath = Path.Combine(localAppData, "Fork", "Fork.exe");
            var projectPath = Directory.GetParent(Application.dataPath).FullName;

            Process.Start(forkPath, projectPath);
        }
    }
}
