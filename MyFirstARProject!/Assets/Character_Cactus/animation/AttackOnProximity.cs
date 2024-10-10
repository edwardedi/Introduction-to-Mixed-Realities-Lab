using UnityEngine;

public class AttackOnProximity : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;
    public float attackDistance = 0.40f;
    private Animator animator1;
    private Animator animator2;

    void Start()
    {
        animator1 = cactus1.GetComponent<Animator>();
        animator2 = cactus2.GetComponent<Animator>();
    }

    void Update()
    {
        if (Vector3.Distance(cactus1.transform.position, cactus2.transform.position) < attackDistance)
        {
            EnterAttack();
        }
    }

    void EnterAttack()
    {
        animator1.SetTrigger("TrAttack");
        animator2.SetTrigger("TrAttack");
    }
}