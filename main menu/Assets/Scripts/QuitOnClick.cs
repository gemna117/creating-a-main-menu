﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour {

    public void Quit()
    {
#if unity_editor
        unityeditor.editorapplication.isPlaying = false;
#else
#endif
    }
}
