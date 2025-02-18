using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    [SerializeField] Animator anim;
    private string animName;

    private void Start()
    {
        ChangeAnim(Constants.ANIM_IDLE);
    }

    public void ChangeAnim(string animName)
    {
        if (this.animName != animName)
        {
            anim.ResetTrigger(this.animName);
            this.animName = animName;
            anim.SetTrigger(this.animName);
        }
    }
    
    //cache transform de toi uu hieu nang
    [SerializeField] protected Transform tf;
    //keo navmesh agent vao
    [SerializeField] private UnityEngine.AI.NavMeshAgent agent;
    //luu diem muc tieu se di den
    private Vector3 destination;

    //property tra ve ket qua xem la da toi diem muc tieu hay chua
    public bool IsDestionation => Vector3.Distance(tf.position, destination + (tf.position.y - destination.y) * Vector3.up) < 0.1f;

    //set diem den
    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        agent.SetDestination(destination);
    }
}
