using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [Header("Character Info")]
    [SerializeField]
    protected int health = 1;
    [SerializeField]
    protected int maxHealth = 1;
    [SerializeField]
    protected int attack = 0;

    protected Rigidbody rb;
    protected SpriteRenderer spriteRenderer;

    public abstract void TakeDamage(Enums.CharType type, int damage);
}