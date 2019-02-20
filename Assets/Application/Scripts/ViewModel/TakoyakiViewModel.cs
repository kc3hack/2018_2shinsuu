using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakoyakiViewModel : SingletonMonoBehaviour<TakoyakiViewModel>
{

    public TakoyakiModel[] takoyakis = {new TakoyakiModel(),new TakoyakiModel(),new TakoyakiModel(),
                                        new TakoyakiModel(),new TakoyakiModel(),new TakoyakiModel()};
    public HoleView[] holes;
    
    // Start is called before the first frame update
    void Start(){
        foreach(HoleView h in holes){
            h.state = State.brank;
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
}
