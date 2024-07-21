using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiRusa : MonoBehaviour
{

    public Animator anim;
    int animasiCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
    //         Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    //         RaycastHit Hit;
    //         if(Physics.Raycast(ray, out Hit)){
    //              anim.Play("Attack");
    //         }
    //         anim.Play("Attack");
    //    }
        
        for(int i=0; i<Input.touchCount; ++i){

            if(Input.GetTouch(i).phase == TouchPhase.Began){
                ChangeAnimation();
            }
           
        //    if(Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle_A")){
        //         anim.Play("Attack");
        //    }else{
        //         anim.Play("Death");
        //    } 
        }

    }

    public void ChangeAnimation(){

        if(animasiCount == 1){
            anim.Play("Roll");
            animasiCount++;
        }else if(animasiCount == 2){
            anim.Play("Death");
            animasiCount++;
        }else if(animasiCount == 3){
            anim.Play("Idle_A");
            animasiCount = 1;
        }
        
        // if(anim.HasState(0, Animator.StringToHash("Idle_A"))){
        //     anim.Play("Roll");
        // }else if(anim.HasState(0, Animator.StringToHash("Roll"))){
        //     anim.Play("Death");
        // }else if(anim.HasState(0, Animator.StringToHash("Death"))){
        //     anim.Play("Idle_A");
        // }else{
        //     anim.Play("Idle_A");
        // }

    }

    
}
