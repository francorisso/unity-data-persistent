using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIMainManager : MonoBehaviour
{
    public static UIMainManager Instance = null;
    public static string playerName = "Anonymous";

    public static int maxScore = 0;

    void Awake()
    {
        if (UIMainManager.Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        UIMainManager.Instance = this;
        DontDestroyOnLoad(UIMainManager.Instance);
    }
}
