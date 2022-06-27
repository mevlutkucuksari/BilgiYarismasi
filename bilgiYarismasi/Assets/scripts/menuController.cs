using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public GameObject bilgipaneli;
    public AudioSource seskontroldosyasi;
    public AudioClip dogrucevapsesi;
    public AudioClip yanliscevapsesi;
    public AudioClip sorusesi;
    private rastgelesahneGecisi sorusecimi;

    private void Start()
    {
        sorusecimi = GetComponent<rastgelesahneGecisi>();
    }
    public void oyunabasla()
    {
        SceneManager.LoadScene(1);
        seskontroldosyasi.PlayOneShot(sorusesi);

    }
    public void bilgiler()
    {
        bilgipaneli.SetActive(true);

    }
    public void cikis()
    {
        Application.Quit();
    }
    public void geritusu()
    {
        bilgipaneli.SetActive(false);
    }

    public void dogrucevapses()
    {
        seskontroldosyasi.PlayOneShot(dogrucevapsesi);
    }

    public void yanliscevapses()
    {
        seskontroldosyasi.PlayOneShot(yanliscevapsesi);
    }
    public void soruyageldiginde()
    {
        seskontroldosyasi.PlayOneShot(sorusesi);
    }
}
