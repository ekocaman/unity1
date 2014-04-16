using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class PeakBoxBuild {


    [MenuItem ("Build/PeakBoxBuild")]
    public static void RunBuild()
    {
        List<string> scenePaths = new List<string> ();
        EditorBuildSettingsScene[] scenes = EditorBuildSettings.scenes;

        foreach (EditorBuildSettingsScene scene in scenes) 
        {
            scenePaths.Add(scene.path);
        }

        Debug.Log("1");

        /*
        BuildPipeline.BuildPlayer (scenePaths.ToArray (),
                                  "iPhoneBuild",
                                  BuildTarget.iPhone,
                                  BuildOptions.None);
        */
        BuildPipeline.BuildPlayer (scenePaths.ToArray (),
                                   "AndroidBuild.apk",
                                   BuildTarget.Android,
                                   BuildOptions.None);

        Debug.Log("2");
        /*
        BuildPipeline.BuildPlayer (scenePaths.ToArray (),
                                   "WebPlayerBuild",
                                   BuildTarget.WebPlayer,
                                   BuildOptions.None);
        */
    }
}