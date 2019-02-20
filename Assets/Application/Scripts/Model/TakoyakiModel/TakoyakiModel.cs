using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakoyakiModel{
    public enum BakeState{
        blank, rare, medium, welldone
    }
    
    public bool isInTako = false;
    public BakeState bakeState = BakeState.blank;
    public float bakeTime = 0f;

}
