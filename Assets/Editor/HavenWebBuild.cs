using UnityEditor;
using UnityEditor.Build.Reporting;
using System.Linq;
public static class HavenWebBuild {
 [MenuItem("Haven/Build itch WebGL")]
 public static void Build() {
  if(!BuildPipeline.IsBuildTargetSupported(BuildTargetGroup.WebGL,BuildTarget.WebGL)) throw new System.Exception("Install WebGL Build Support for Unity 2020.3.24f1 in Unity Hub first.");
  PlayerSettings.WebGL.compressionFormat=WebGLCompressionFormat.Gzip;
  PlayerSettings.WebGL.decompressionFallback=true;
  PlayerSettings.defaultWebScreenWidth=1280; PlayerSettings.defaultWebScreenHeight=720;
  var scenes=EditorBuildSettings.scenes.Where(s=>s.enabled).Select(s=>s.path).ToArray();
  if(scenes.Length==0) throw new System.Exception("No enabled build scenes.");
  var report=BuildPipeline.BuildPlayer(scenes,"Builds/itch-web",BuildTarget.WebGL,BuildOptions.None);
  if(report.summary.result!=BuildResult.Succeeded) throw new System.Exception("Web build failed. Check Console.");
 }
}
