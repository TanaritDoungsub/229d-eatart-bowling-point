using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmeCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreManager.scoreCount += 1;
        }
    }
}
