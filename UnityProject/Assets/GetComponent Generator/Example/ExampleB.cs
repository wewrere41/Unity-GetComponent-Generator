using UnityEngine;
using UnityEngine.AI;
using static GetComponentAttribute.TargetType;

public partial class ExampleB : MonoBehaviour
{
    [GetComponent] private NavMeshAgent _navMeshAgents;
    [GetComponent] private BoxCollider _boxCollider;
    [GetComponent] private SpriteRenderer _spriteRenderer;
    [GetComponent(Parent)] private Rigidbody _rigidbody;
    [GetComponent(Child)] private MeshRenderer _meshRenderer;

    private void Awake() => InitializeComponents();
}


public partial class ExampleC : MonoBehaviour
{
    [GetComponent] private NavMeshAgent _navMeshAgents;
    [GetComponent] private BoxCollider _boxCollider;
    [GetComponent] private SpriteRenderer _spriteRenderer;
    [GetComponent(Parent)] private Rigidbody _rigidbody;
    [GetComponent(Child)] private MeshRenderer _meshRenderer;

    //private void Awake() => InitializeComponents();
}