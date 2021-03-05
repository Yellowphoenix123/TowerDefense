using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DamageTower : MonoBehaviour
{
    public AudioClip myClip;
    private AudioSource mySource;
    public float damag;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider EnemyCollider)
    {

        
        if (EnemyCollider.tag == ("Enemy"))
        {
            
           damag = EnemyCollider.GetComponent<HealthBar>().fill -= 0.4f;
            
            
        }
    }
}
