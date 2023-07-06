using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ControllerSwitcher : MonoBehaviour
{
    public StarterAssetsInputs inputs;

    public GameObject joysticks;

    // Start is called before the first frame update
    IEnumerator Start()
    {
      yield return new WaitForSeconds(1);

#if UNITY_WEBGL
    if (Platform.IsMobileBrowser())
    {
      SwitchToJoystick();
    }
    //else
    //{
    //  // whatever for desktop browser
    //}
#endif

#if UNITY_ANDROID
    SwitchToJoystick();
#endif
  }

  void SwitchToJoystick()
  {
    inputs.cursorInputForLook = false;
    inputs.cursorLocked = false;
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
    joysticks.SetActive(true);
  }

  // Update is called once per frame
  //void Update()
  //  {
        
  //  }
}
