using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    public static int SceneActive = 0;

    public static int Position = -1;
    public static int SpawnPosition;
    public static bool ChangerEtage = false;
    public static GameObject player;

    private void Awake()
    {
            player = GameObject.FindGameObjectWithTag("Player");
    }

}
