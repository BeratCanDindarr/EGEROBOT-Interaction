using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class CameraController : MonoBehaviour
{

    public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;

    private FirstPersonController firstPersonController;
    private ThirdPersonController thirdPersonController;

    bool thirdPersonCameraActive = true;
    // Start is called before the first frame update
    void Start()
    {
        firstPersonController = GameManager.Instance.player.GetComponent<FirstPersonController>();
        thirdPersonController = GameManager.Instance.player.GetComponent<ThirdPersonController>();
        CameraChange(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (thirdPersonCameraActive == true)
            {
                CameraChange(false);
            }
            else
            {
                CameraChange(true);
            }
        }
    }


    void CameraChange(bool actived)
    {
        thirdPersonCamera.gameObject.active = actived;
        thirdPersonController.enabled = actived;
        firstPersonCamera.gameObject.active = !actived;
        firstPersonController.enabled = !actived;
        thirdPersonCameraActive = actived;
    }
}
