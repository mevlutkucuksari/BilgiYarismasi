using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sayac : MonoBehaviour
{
    public float zaman=30;
    public TextMeshProUGUI zamansayaci;
    public GameObject surebittiekrani;
  
    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        zamansayaci.text = " " + (int)zaman;

        if (zaman<=0)
        {
            zaman = 0;
            surebittiekrani.SetActive(true);
        }
    }
}
