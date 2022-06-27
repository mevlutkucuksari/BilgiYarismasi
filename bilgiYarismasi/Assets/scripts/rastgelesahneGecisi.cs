using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class rastgelesahneGecisi : MonoBehaviour
{
    public GameObject[] sorular = new GameObject[15];
    public GameObject DogruPaneli;
    public GameObject YanlisPaneli;
    public int puan;
    public int sorusaymasayaci;
    public TextMeshProUGUI toplananpuan;
    public TextMeshProUGUI sorusayma;
    public TextMeshProUGUI skor;
    public float zaman = 30;
    public TextMeshProUGUI zamansayaci;
    public menuController menu;
    public AudioSource seskontroldosyasi;
    public AudioClip sorusesi;
    public sayac sayac;

    private void Start()
    {
        sayac sayac = GetComponent<sayac>();

    }
    private void Update()
    {
        
    }

    public  void rastgelesahne()
    {
        int sayi = Random.Range(0,sorular.Length);
        Debug.Log(sayi);
    }
    public void dogrucevap()
    {
        DogruPaneli.SetActive(true);
        puan += 10;
        sorusaymasayaci++;
        sorusayma.text = sorusaymasayaci.ToString();
        skor.text = puan.ToString();
        menu.dogrucevapses();
        
    }
    public void yanliscevap()
    {
        YanlisPaneli.SetActive(true);
        toplananpuan.text = puan.ToString();
        menu.yanliscevapses();
    }
    public void sonrakisoru()
    {

        for (int i = 0; i < sorular.Length; i++)
        {
            sorular[i].SetActive(false);
        }
        int sayi = Random.Range(1, sorular.Length);
        sorular[sayi].SetActive(true);
        DogruPaneli.SetActive(false);
        menu.soruyageldiginde();
        sayac.zaman = 30;


    }
    public void yenidenbasla()
    {
        SceneManager.LoadScene(0);
    }
    public void cikis()
    {
        Application.Quit();
    }
}
