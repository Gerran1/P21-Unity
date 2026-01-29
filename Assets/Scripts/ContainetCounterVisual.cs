using UnityEngine;

public class ContainetCounterVisual : MonoBehaviour
{
    [SerializeField]
    private ContainerCounter containerCounter;

    private Animator animator;

    private const string OPENCLOSE = "OpenClose";

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        containerCounter.OnPlayerGrabbedObject += ContainerCounter_OnPlayerGrabbedObject;
    }

    private void ContainerCounter_OnPlayerGrabbedObject(object sender, System.EventArgs e)
    {
        animator.SetTrigger(OPENCLOSE);
    }
}
