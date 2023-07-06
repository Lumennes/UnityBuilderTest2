using UnityEngine;
using System.Runtime.InteropServices;
public class WebGLHandler : MonoBehaviour
{
  [DllImport("__Internal")]
  public static extern bool IsMobileBrowser();
}
