using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // add score
    public static int ScoreValue = 0;
    Text Scoretext;
    
    
   
    
    

    
   


    void Update()
    {
      
        
        Scoretext.text = "Score: " + ScoreValue;
      

       
        
    }
}

         
        
        
