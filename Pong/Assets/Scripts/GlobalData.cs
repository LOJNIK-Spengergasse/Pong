using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class GlobalData
{
    public static int LeftScore { get; set; } = 0;
    public static int RightScore { get; set; } = 0;
    public static int LastWin { get; set; } = 1; 

    public static bool isAI {  get; set; }
    public static float AIerrorRange;

    public static int winCond { get; set; }
}