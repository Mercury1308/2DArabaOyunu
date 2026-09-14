using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI skor_tx;
    public static float skor;
    void Start()
    {
        skor = 0;
    }

    void Update()
    {
        skor_tx.text = skor.ToString();
    }
}
