using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    int timePlayed = 0;
    public TextMeshProUGUI textObj; // assign from the inspector.
    void Start()
    {
        // maybe you want it to begin here
        StartCoroutine(GameCounter());
    }
    IEnumerator GameCounter()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        while (true)
        {
            textObj.text = timePlayed.ToString();
            yield return wfs;
            timePlayed++;
        }
    }
}
