using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Animations : MonoBehaviour
{
    private Animator PlayerAnimator {get => GetComponent<Animator>();}
    [SerializeField] private AnimationClip[] _Animation = new AnimationClip[7];

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
            PlayerAnimator.Play(_Animation[0].name);
        if (Input.GetKeyDown(KeyCode.Keypad1))
            PlayerAnimator.Play(_Animation[1].name);
        if (Input.GetKeyDown(KeyCode.Keypad2))
            PlayerAnimator.Play(_Animation[2].name);
        if (Input.GetKeyDown(KeyCode.Keypad3))
            PlayerAnimator.Play(_Animation[4].name);
        if (Input.GetKeyDown(KeyCode.Keypad4))
            PlayerAnimator.Play(_Animation[5].name);
        if (Input.GetKeyDown(KeyCode.Keypad4))
            PlayerAnimator.Play(_Animation[6].name);
        if (Input.GetKeyDown(KeyCode.Keypad7))
            PlayerAnimator.Play(_Animation[7].name);

    }
}
