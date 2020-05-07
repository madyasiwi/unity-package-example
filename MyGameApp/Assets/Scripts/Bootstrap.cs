using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MyPlatform;


public class Bootstrap {

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
    static void InitializePlatformSDK() {
        Debug.Log("Initializing platform...");
        if (Core.Initialize()) {
            Debug.Log("Success!");
        }
    }
}
