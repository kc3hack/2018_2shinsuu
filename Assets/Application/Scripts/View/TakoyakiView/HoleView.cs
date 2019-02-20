using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleView : MonoBehaviour
{
    public Sprite spriteKara;
    public Sprite sprite1;
    
    public int s = 0;
    enum State{
        blank, rare, medium, welldone
    }
    public State state = State.blank;
    
    public void changeSprite(){
        switch(State){
            case State.blank:
                this.gameObject.GetComponent<Image> ().sprite = sprite1;
                break;
            case State.rare:
                this.gameObject.GetComponent<Image> ().sprite = spriteKara;
                break;
            case State.medium:
                
            case State.welldone:
                
        }    
            
        if (s%2==0){
            this.gameObject.GetComponent<Image> ().sprite = sprite1;
            s += 1;
        }else if(s%2==1){
            this.gameObject.GetComponent<Image> ().sprite = spriteKara;
            s += 1;
        }
    }
}
