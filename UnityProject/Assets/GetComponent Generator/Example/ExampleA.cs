using UnityEngine;
using UnityEngine.AI;

public class ExampleA : MonoBehaviour
{
    private NavMeshAgent _navMeshAgents;
    private BoxCollider _boxCollider;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody _rigidbody;
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _navMeshAgents = GetComponent<NavMeshAgent>();
        _boxCollider = GetComponent<BoxCollider>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponentInParent<Rigidbody>();
        _rigidbody = GetComponentInChildren<Rigidbody>();
    }
}