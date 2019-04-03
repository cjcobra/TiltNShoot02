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

    private static BonusWeaponCoroutine instance;
    public static BonusWeaponCoroutine Instance { get { return instance; } }



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

            // Look for which Mege Weapon Block was hit
            if (gameObject.tag == "MegaWeaponBlock01")
            {
                Debug.Log("Mega Weapon Block 01 Hit");
                StartMegaWeapon01();
            }

            if (gameObject.tag == "MegaWeaponBlock02")
            {
                Debug.Log("Mega Weapon Block 02 Hit");
                StartMegaWeapon02();
            }
            if (gameObject.tag == "MegaWeaponBlock03")
            {
                Debug.Log("Mega Weapon Block 03 Hit");
                StartMegaWeapon03();
            }
            if (gameObject.tag == "MegaWeaponBlock04")
            {
                Debug.Log("Mega Weapon Block 04 Hit");
                StartMegaWeapon04();
            }
            if (gameObject.tag == "MegaWeaponBlock05")
            {
                Debug.Log("Mega Weapon Block 05 Hit");
                StartMegaWeapon05();
            }
            if (gameObject.tag == "MegaWeaponBlock06")
            {
                Debug.Log("Mega Weapon Block 06 Hit");
                StartMegaWeapon06();
            }
            if (gameObject.tag == "MegaWeaponBlock07")
            {
                Debug.Log("Mega Weapon Block 07 Hit");
                StartMegaWeapon07();
            }
            if (gameObject.tag == "MegaWeaponBlock08")
            {
                Debug.Log("Mega Weapon Block 08 Hit");
                StartMegaWeapon08();
            }
            if (gameObject.tag == "MegaWeaponBlock09")
            {
                Debug.Log("Mega Weapon Block 09 Hit");
                StartMegaWeapon09();
            }
            if (gameObject.tag == "MegaWeaponBlock10")
            {
                Debug.Log("Mega Weapon Block 10 Hit");
                StartMegaWeapon10();
            }
            // Destroy(gameObject);
            //   source.PlayOneShot(NewWeapon);
            //   BonusWeapon.SetActive(true);
            //   BonusWeaponButton.SetActive(true);  //////// MUST PUSH BUTTON
            //   WeaponButton.SetActive(false);
            //   Weapon.SetActive(false);
            //   bonusweapontimer.StartTimer();

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
/////////// Mega Weapon 01
    public void StartMegaWeapon01()
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

    /////////// Mega Weapon 02
    public void StartMegaWeapon02()
    {
        Debug.Log("StartMegaWeapon02");

        GameObject varGameObject5 = GameObject.FindWithTag("Player2");
        varGameObject5.GetComponent<MegaWeapon02>().enabled = true;

        GameObject varGameObject6 = GameObject.FindWithTag("Player2");
        varGameObject6.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon02()
    {
        Debug.Log("StopMegaWeapon02");

        GameObject varGameObject7 = GameObject.FindWithTag("Player2");
        varGameObject7.GetComponent<MegaWeapon02>().enabled = false;

        GameObject varGameObject8 = GameObject.FindWithTag("Player2");
        varGameObject8.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 03
    public void StartMegaWeapon03()
    {
        Debug.Log("StartMegaWeapon03");

        GameObject varGameObject9 = GameObject.FindWithTag("Player2");
        varGameObject9.GetComponent<MegaWeapon03>().enabled = true;

        GameObject varGameObject10 = GameObject.FindWithTag("Player2");
        varGameObject10.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon03()
    {
        Debug.Log("StopMegaWeapon03");

        GameObject varGameObject11 = GameObject.FindWithTag("Player2");
        varGameObject11.GetComponent<MegaWeapon03>().enabled = false;

        GameObject varGameObject12 = GameObject.FindWithTag("Player2");
        varGameObject12.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 04
    public void StartMegaWeapon04()
    {
        Debug.Log("StartMegaWeapon04");

        GameObject varGameObject13 = GameObject.FindWithTag("Player2");
        varGameObject13.GetComponent<MegaWeapon04>().enabled = true;

        GameObject varGameObject14 = GameObject.FindWithTag("Player2");
        varGameObject14.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon04()
    {
        Debug.Log("StopMegaWeapon04");

        GameObject varGameObject15 = GameObject.FindWithTag("Player2");
        varGameObject15.GetComponent<MegaWeapon04>().enabled = false;

        GameObject varGameObject16 = GameObject.FindWithTag("Player2");
        varGameObject16.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 05
    public void StartMegaWeapon05()
    {
        Debug.Log("StartMegaWeapon05");

        GameObject varGameObject17 = GameObject.FindWithTag("Player2");
        varGameObject17.GetComponent<MegaWeapon05>().enabled = true;

        GameObject varGameObject18 = GameObject.FindWithTag("Player2");
        varGameObject18.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon05()
    {
        Debug.Log("StopMegaWeapon05");

        GameObject varGameObject19 = GameObject.FindWithTag("Player2");
        varGameObject19.GetComponent<MegaWeapon05>().enabled = false;

        GameObject varGameObject20 = GameObject.FindWithTag("Player2");
        varGameObject20.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 06
    public void StartMegaWeapon06()
    {
        Debug.Log("StartMegaWeapon06");

        GameObject varGameObject21 = GameObject.FindWithTag("Player2");
        varGameObject21.GetComponent<MegaWeapon06>().enabled = true;

        GameObject varGameObject22 = GameObject.FindWithTag("Player2");
        varGameObject22.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon06()
    {
        Debug.Log("StopMegaWeapon06");

        GameObject varGameObject23 = GameObject.FindWithTag("Player2");
        varGameObject23.GetComponent<MegaWeapon06>().enabled = false;

        GameObject varGameObject24 = GameObject.FindWithTag("Player2");
        varGameObject24.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 07
    public void StartMegaWeapon07()
    {
        Debug.Log("StartMegaWeapon07");

        GameObject varGameObject25 = GameObject.FindWithTag("Player2");
        varGameObject25.GetComponent<MegaWeapon07>().enabled = true;

        GameObject varGameObject26 = GameObject.FindWithTag("Player2");
        varGameObject26.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon07()
    {
        Debug.Log("StopMegaWeapon07");

        GameObject varGameObject27 = GameObject.FindWithTag("Player2");
        varGameObject27.GetComponent<MegaWeapon07>().enabled = false;

        GameObject varGameObject28 = GameObject.FindWithTag("Player2");
        varGameObject28.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 08
    public void StartMegaWeapon08()
    {
        Debug.Log("StartMegaWeapon08");

        GameObject varGameObject29 = GameObject.FindWithTag("Player2");
        varGameObject29.GetComponent<MegaWeapon08>().enabled = true;

        GameObject varGameObject30 = GameObject.FindWithTag("Player2");
        varGameObject30.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon08()
    {
        Debug.Log("StopMegaWeapon08");

        GameObject varGameObject31 = GameObject.FindWithTag("Player2");
        varGameObject31.GetComponent<MegaWeapon08>().enabled = false;

        GameObject varGameObject32 = GameObject.FindWithTag("Player2");
        varGameObject32.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 09
    public void StartMegaWeapon09()
    {
        Debug.Log("StartMegaWeapon09");

        GameObject varGameObject33 = GameObject.FindWithTag("Player2");
        varGameObject33.GetComponent<MegaWeapon08>().enabled = true;

        GameObject varGameObject34 = GameObject.FindWithTag("Player2");
        varGameObject34.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon09()
    {
        Debug.Log("StopMegaWeapon09");

        GameObject varGameObject35 = GameObject.FindWithTag("Player2");
        varGameObject35.GetComponent<MegaWeapon09>().enabled = false;

        GameObject varGameObject36 = GameObject.FindWithTag("Player2");
        varGameObject36.GetComponent<Weapon03b>().enabled = true;
    }

    /////////// Mega Weapon 10
    public void StartMegaWeapon10()
    {
        Debug.Log("StartMegaWeapon10");

        GameObject varGameObject37 = GameObject.FindWithTag("Player2");
        varGameObject37.GetComponent<MegaWeapon10>().enabled = true;

        GameObject varGameObject38 = GameObject.FindWithTag("Player2");
        varGameObject38.GetComponent<Weapon03b>().enabled = false;

        StartCoroutine(megaWeaponCountDown());
    }

    void StopMegaWeapon10()
    {
        Debug.Log("StopMegaWeapon10");

        GameObject varGameObject39 = GameObject.FindWithTag("Player2");
        varGameObject39.GetComponent<MegaWeapon10>().enabled = false;

        GameObject varGameObject40 = GameObject.FindWithTag("Player2");
        varGameObject40.GetComponent<Weapon03b>().enabled = true;
    }

    // Stop timer and revert back to primary weapon
    IEnumerator megaWeaponCountDown()
    {
        Debug.Log("StartMegaWeaponCountDown");

        yield return new WaitForSeconds(megaWeaponTimer);
        StopMegaWeapon01();
        StopMegaWeapon02();
        StopMegaWeapon03();
        StopMegaWeapon04();
        StopMegaWeapon05();
        StopMegaWeapon06();
        StopMegaWeapon07();
        StopMegaWeapon08();
        StopMegaWeapon09();
        StopMegaWeapon10();
    }




}
