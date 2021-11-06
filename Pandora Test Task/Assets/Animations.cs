using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Animations : MonoBehaviour
{
    private Animator PlayerAnimator {get => GetComponent<Animator>();}
    [SerializeField] private AnimationClip[] _Animation = new AnimationClip[4];
    [SerializeField, Range(0f, 10f)] private float WalkSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            PlayerAnimator.Play(_Animation[0].name);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            PlayerAnimator.Play(_Animation[1].name);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            PlayerAnimator.Play(_Animation[2].name);
            transform.position += Vector3.forward * Time.deltaTime * WalkSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            PlayerAnimator.Play(_Animation[3].name);
        }
    }
}
