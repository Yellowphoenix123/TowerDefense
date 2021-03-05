using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



namespace Assets.Scripts
{
   public class Damage
   {


        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void OnTriggerEnter(Collider EnemyCollider)
        {


            if (EnemyCollider.tag == ("Enemy"))
            {

                EnemyCollider.GetComponent<HealthBar>().fill -= 0.3f;


            }
        }
    }
}
