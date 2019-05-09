using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseFollower : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        MobileUpdater();
        DeskTopUpdater();
    }


    private void MobileUpdater() {
        if (Input.touchCount > 0)
        {
            Vector3 pz = Input.GetTouch(0).position;
            pz.z = 0;
            gameObject.transform.position = pz;

        }
    }

    private void DeskTopUpdater()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition/*posicion del dedo*/);
            pz.z = 0;
            gameObject.transform.position = pz;
        }
    }


 /*   void FollowerUpdater() {
#if UNITY_STANDALONE || UNITY_WEBGL
        if (Input.GetMouseButton(0))
        {
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition/*posicion del dedo);
            pz.z = 0;
            gameObject.transform.position = pz;
        }

#elif UNITY_ANDROID || UNITY_IOS
        if (Input.touchCount > 0)
        {
            Vector3 pz = Input.GetTouch(0).position;
            pz.z = 0;
            gameObject.transform.position = pz;

        }
#endif

    }*/

}
