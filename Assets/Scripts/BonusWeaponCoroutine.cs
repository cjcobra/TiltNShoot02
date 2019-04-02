using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusWeaponCoroutine : MonoBehaviour
{

    [SerializeField] public GameObject BonusWeapon;
    [SerializeField] public GameObject BonusWeaponButton;
    [SerializeField] private int timer;
    public GameObject WeaponButton;
    public GameObject Weapon;

    public AudioSource source;
    public AudioClip NewWeapon;
    public AudioClip BacktoBasicWeapon;

    public CircularTimer bonusweapontimer;

    // CJ
    public float megaWeaponTimer = 5f;
   // float timer2;


    private void Start()
    {

        Debug.Log("BonusWeaonCorountine");

        BonusWeapon.SetActive(false);
        BonusWeaponButton.SetActive(false);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BulletBall"))
        {
            Debug.Log("BWC_Collider Hit");

            // CJ
            StartMegaWeapon01();

            // Destroy(gameObject);
            source.PlayOneShot(NewWeapon);
            BonusWeapon.SetActive(true);
            BonusWeaponButton.SetActive(true);  //////// MUST PUSH BUTTON
            WeaponButton.SetActive(false);
            Weapon.SetActive(false);
            bonusweapontimer.StartTimer();
      // CJ      StartCoroutine(ShowObject());

        }
    }

 /*
    IEnumerator ShowObject()
    {
        yield return new WaitForSeconds(timer);
        source.PlayOneShot(BacktoBasicWeapon);
        BonusWeapon.SetActive(false);
        BonusWeaponButton.SetActive(false);
        WeaponButton.SetActive(true);
        Weapon.SetActive(true);
        Destroy(gameObject);
    }
*/
    void StartMegaWeapon01()
    {
        Debug.Log("StartMegaWeapon01");

        GameObject varGameObject = GameObject.FindWithTag("Player2");
        varGameObject.GetComponent<MegaWeapon01>().enabled = true;

        GameObject varGameObject2 = GameObject.FindWithTag("Player2");
        varGameObject2.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon01()
    {
        Debug.Log("StopMegaWeapon01");

        GameObject varGameObject3 = GameObject.FindWithTag("Player2");
        varGameObject3.GetComponent<MegaWeapon01>().enabled = false;

        GameObject varGameObject4 = GameObject.FindWithTag("Player2");
        varGameObject4.GetComponent<Weapon03b>().enabled = true;
    }

    IEnumerator megaWeaponCountDown()
    {
        Debug.Log("megaWeaponCountDown");

        yield return new WaitForSeconds(megaWeaponTimer);
        StopMegaWeapon01();
    }




}
