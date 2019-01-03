using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject gameWinUI;
    // If ball collides with the win cube, display win UI
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Win Cube")
        {
            Destroy(gameObject);
            gameWinUI.SetActive(true);
        }
    }
}
