using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class tutorialAnimation : MonoBehaviour
{
    public GameObject parent;
    Animator animator;
    public TeleportPoint tpPoint;
    private bool animationDone = false;
    public MenuInteraction menuInteraction;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Animations());
        }
    }
    IEnumerator Animations()
    {
        while (true)
        {
            if (!animationDone)
            {
                var audio = GetComponent<AudioSource>();
                animator.SetBool("isTalking", true);
                audio.clip = Resources.Load<AudioClip>("Sounds/UsingMenuSimple");
                audio.Play();
                yield return new WaitForSeconds(5.0f);
                audio.clip = Resources.Load<AudioClip>("Sounds/LetMeDemonstrate");
                audio.Play();
                animator.SetBool("doneTalking", true);
                yield return new WaitForSeconds(1f);
                animator.SetBool("doneTurning", true);
                yield return new WaitForSeconds(2.0f);
                audio.clip = Resources.Load<AudioClip>("Sounds/click");
                audio.Play();
                menuInteraction.setSettings();
                animator.SetBool("donePushing", true);
                yield return new WaitForSeconds(0.0f);
                animator.SetBool("doneTurningAfterPushing", true);
                yield return new WaitForSeconds(1.0f);
                animator.SetBool("isDoneTalkingAfterPushing", true);
                audio.clip = Resources.Load<AudioClip>("Sounds/see");
                audio.Play();
                yield return new WaitForSeconds(4.0f);
                audio.clip = Resources.Load<AudioClip>("Sounds/TryItyourself");
                audio.Play();
                animator.SetBool("isTalking", false);
                animator.SetBool("AnimationDone", true);
                tpPoint.locked = false;
                animationDone = true;

            }
            yield return new WaitForSeconds(3.0f);
        }
    }
}
