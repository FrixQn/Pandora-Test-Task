using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class Animations : MonoBehaviour
{
    private Animator PlayerAnimator {get => GetComponent<Animator>();}
    [SerializeField] private AnimationClip _Walk;
    [SerializeField] private AnimationClip _Idle;
    [SerializeField] private AnimationClip _Run;
    [SerializeField] private AnimationClip _Lought;
    [SerializeField, Range(0f, 10f)] private float WalkSpeed;
    //States

    private bool Walk = true;
    private bool Idle;
    private bool Run;
    private bool Lought;

    private void Update()
    {
        if (Walk){
            PlayerAnimator.Play(_Walk.name);
            transform.position += Vector3.forward * Time.deltaTime * WalkSpeed;
        }
        if (Run)
        {
            PlayerAnimator.Play(_Run.name);
            transform.position += Vector3.forward * Time.deltaTime * 3 * WalkSpeed;
        }
        if (Idle)
        {
            PlayerAnimator.Play(_Idle.name);
        }
        if (Lought)
        {
            PlayerAnimator.Play(_Lought.name);
        }
    }

}
