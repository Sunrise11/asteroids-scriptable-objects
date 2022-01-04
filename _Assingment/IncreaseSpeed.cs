using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Ship;

public class IncreaseSpeed : MonoBehaviour
{
    public Engine engine;


    

  public void SpeedBoost()
    {
        
        engine._throttlePower.ChangeAmoutBy(10);

        Debug.Log(engine._throttlePower);

       
    }

}
