using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jude.MyCod
{
    public class Raycast : MonoBehaviour
    {
        public float raycastLength;
        
        private void Update()
        {
            Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.magenta);
            Debug.Log("Raycast");
        }
    }
}
