using System;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ForkLauncher
{
    [MenuItem("Fork/Launch Fork")]
    public static void LaunchFork()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsEditor:
                var projectPath = Directory.GetParent(Application.dataPath).FullName;
                var localApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var forkPath = Path.Combine(localApplicationData, "Fork", "Fork.exe");
                Process.Start(forkPath, projectPath);
                break;
            case RuntimePlatform.OSXEditor:
                Process.Start("open", "-a Fork .");
                break;
            default:
                throw new PlatformNotSupportedException();
        }
    }
}
