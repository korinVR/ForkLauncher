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
        public static void LaunchFork()
        {
            var localApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var forkPath = Path.Combine(localApplicationData, "Fork", "Fork.exe");
            var projectPath = Directory.GetParent(Application.dataPath).FullName;

            Process.Start(forkPath, projectPath);
        }
    }
}
