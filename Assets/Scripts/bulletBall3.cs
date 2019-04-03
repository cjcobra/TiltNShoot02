using UnityEngine;

public class bulletBall3 : MonoBehaviour
{

   // public float delay = .3f;
    public float speed = 10f;  //cj 20f
   // public float force = 700f;
   // public float radius = 5f;
    public Rigidbody rb;

    //float countdown;
 //   bool hasExploded = false;

    public GameObject explosionEffect;

  //  public BonusWeaponCoroutine scriptBonusWeaonCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bulletBall3");

        //countdown = delay;
        rb.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("BackWall"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "MegaWeaponBlock01")   // else if
        {
            Debug.Log("BulletBall3, MegaWeaponBlock01 Hit");  // This shows up in the console

            BonusWeaponCoroutine.Instance.StartMegaWeapon01();  // WONT FUCKING CALL THIS FUNCTION!!!!!!!!
        }








    }

    


}
