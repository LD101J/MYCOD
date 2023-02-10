using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jude.MyCod
{
    public class LookAround : MonoBehaviour
    {
        #region Variables for LookAround
        [SerializeField] private GameObject mainCamera;
        [SerializeField] private float horizontalCameraLook;
        [SerializeField] private float verticalCameraLook;
        [SerializeField] private float lookSpeed;
        //Vertical
        [SerializeField] private float VminLookAngle;
        [SerializeField] private float VmaxLookAngle;
        //horizontal    
        [SerializeField] private float HminLookAngle;
        [SerializeField] private float HmaxLookAngle;
        #endregion


        private void Update()
        {
            #region Look Around using Mouse
            horizontalCameraLook = Input.GetAxis("Mouse X") * lookSpeed;
            verticalCameraLook = Input.GetAxis("Mouse Y") * lookSpeed;


            //the coordinates are being used to move
            transform.Rotate(-verticalCameraLook, 0, 0);
            transform.Rotate(0, -horizontalCameraLook, 0);

            //mainCamera.transform.Rotate(0, horizontalCameraLook, 0);
            //mainCamera.transform.Rotate(vertical, 0, 0);
            #endregion
            #region Camera clamping
            //camera clamping
            if (mainCamera.transform.localEulerAngles.x > 180f)
            {
                float angle = mainCamera.transform.localEulerAngles.x - 360f;
                angle = Mathf.Clamp(angle, VminLookAngle, VmaxLookAngle);
                mainCamera.transform.localEulerAngles = new Vector3(angle, 0f, 0f);
            }
            else
            {
                float angle = Mathf.Clamp(mainCamera.transform.localEulerAngles.x, HminLookAngle, HmaxLookAngle);
                mainCamera.transform.localEulerAngles = new Vector3(angle, 0f, 0f);
            }
            #endregion
        }

    }
}
