using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Objetcs
{
    // [RequireComponent(typeof(Rigidbody2D))]
    public class Object2 : MonoBehaviour
    {
        [Header("Life configurations")][Space(5)]
        [Tooltip("Life configurations")]
        [SerializeField][Range(1,10)]private int life = 10; 
        // [SerializeField][Range(1,10)]private int mana = 10; 
        // [SerializeField][Range(1,10)]private int stamina = 10; 
        [Space(15)]
        
        [Header("Text configurations")][Space(5)]
        [Tooltip("Test message")]
        [SerializeField][Multiline]private string testText; 

        // private Rigidbody2D _rigidBodyCharacter;
        void Start()
        {
            Debug.Log(life);
            // _rigidBodyCharacter = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // Debug.Log(_rigidBodyCharacter.velocity);
        }
    }
    
}
