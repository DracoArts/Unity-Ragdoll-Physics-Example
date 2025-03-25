using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollGUI : MonoBehaviour
{
     [SerializeField]
    private ActiveRagDoll[] Ragdolls;
    
    [SerializeField]
    private float UpwardModifier = 2;
    [SerializeField]
    private float ExplosiveRadius = 2f;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 250, 30), "Active RagDoll"))
        {
            foreach(ActiveRagDoll ragdoll in Ragdolls)
            {
                ragdoll.EnableRagdoll();
                
            }
        }
        else if (GUI.Button(new Rect(10, 50, 250, 30), "Active  Animator"))
        {
            foreach (ActiveRagDoll ragdoll in Ragdolls)
            {
                ragdoll.EnableAnimator();
            }
        }
       
    }

   
}
