using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnJoueur : MonoBehaviour
{
    private int GoInto = 0;


    void Update()
    {

        if (Global.ChangerEtage == true)
        {
            switch (Global.Position)
            {
                case 0: GoInto = -1; Global.SpawnPosition = 0; break;
                case 1: GoInto = 1;  Global.SpawnPosition = 1; break;
                case 2: GoInto = -1; Global.SpawnPosition = 2; break;
                case 3: GoInto = 1;  Global.SpawnPosition = 3; break;
                case 4: GoInto = -1; Global.SpawnPosition = 4; break;
                case 5: GoInto = 1;  Global.SpawnPosition = 5; break;
                case 6: GoInto = -1; Global.SpawnPosition = 6; break;
                case 7: GoInto = 1;  Global.SpawnPosition = 7; break;
            }
            SpawnPlayer();

        }

    }

    
    void SpawnPlayer()
     {
        SceneManager.LoadScene(Global.SceneActive + GoInto);
        Global.SceneActive = Global.SceneActive + GoInto;

        Global.ChangerEtage = false;

        Debug.Log("SpawnPosition = "+ Global.SpawnPosition);
    }



}
