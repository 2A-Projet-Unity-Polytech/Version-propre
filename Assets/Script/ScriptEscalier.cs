using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEscalier : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        Global.Position = int.Parse(this.name);
        Global.ChangerEtage = true;
    }
}
