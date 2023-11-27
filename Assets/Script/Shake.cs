using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{


  //  public SpriteRenderer sp;

    void Start()
    {
         this.gameObject.transform.DOShakePosition(3, 2, 0, 2, true, true).SetLoops(-1, LoopType.Restart);
       
       // sp.DOFade(0,1).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        
    }

}
