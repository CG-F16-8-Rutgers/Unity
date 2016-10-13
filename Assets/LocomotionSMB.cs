using UnityEngine;
using System.Collections;
using UnityEditor.Animations;


public class LocomotionSMB : StateMachineBehaviour {

    public float m_Damping = 0.15f;


    private readonly int m_HashHorizontalPara = Animator.StringToHash("Horizontal");
    private readonly int m_HashVerticalPara = Animator.StringToHash("Vertical");

 

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 input = new Vector2(horizontal, vertical).normalized;

        animator.SetFloat(m_HashHorizontalPara, input.x, m_Damping, Time.deltaTime);
        animator.SetFloat(m_HashVerticalPara, input.y, m_Damping, Time.deltaTime);

        animator.SetBool("Shift", Input.GetKey(KeyCode.LeftShift));
        Debug.Log(animator.GetBool("Shift"));

        animator.SetBool("Space", Input.GetKey(KeyCode.Space));
        Debug.Log(animator.GetBool("Space"));

        animator.SetBool("Q", Input.GetKey(KeyCode.Q));
        Debug.Log(animator.GetBool("Q"));

        animator.SetBool("E", Input.GetKey(KeyCode.E));
        Debug.Log(animator.GetBool("E"));


    }


}
