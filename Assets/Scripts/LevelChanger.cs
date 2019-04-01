using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        Debug.Log("LevelChanger");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToLevel (int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }



}
