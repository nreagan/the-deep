﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CurrentScore {
    private static int score;
    private static int level;

    public static int Score {
        get {
            return score;
        }
        set {
            score = value;
        }
    }

    public static int Level {
        get {
            return level;
        }
        set {
            level = value;
        }
    }
}
