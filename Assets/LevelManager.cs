using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Sprite[] sprites;

    private void Start()
    {
        GameManager.Instance.startGM();
    }
}
