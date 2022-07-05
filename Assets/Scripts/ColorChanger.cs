using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
     public MeshRenderer myRenderer;

     public Color anotherColor;

     private Color startColor;

     public float totalDuration;

     private float currentDuration;

     public float testFloat;

     public Color[] newColors;

     private int colorIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
       startColor = myRenderer.material.color;
       Debug.Log("START GAME");
    }

    // Update is called once per frame
    void Update()
    {
        // Check whether current duration has met total duration
        // if it hasn't, run code in the curly braces
        if(currentDuration < totalDuration)
        {
            // Get the amount of time pass relative top the total duration
            float changePercent = currentDuration / totalDuration;
            Debug.Log(changePercent);
            // Use the Lerp function to get a Color between startColour and anotherColor
            // Pass in changePercent to set how far along the Lerp to get a colour from.
            myRenderer.material.color = Color.Lerp(startColor,newColors[colorIndex],changePercent);

            // Add Time.deltaTime to currentDuration every frame
            currentDuration += Time.deltaTime;
        }
        // Else,reset currentDuration and increaae colorIndex
        else
        {
            ++colorIndex;
            if (colorIndex >= newColors.Length)
            {
                colorIndex = 0;
            }
            currentDuration = 0f;
            startColor = myRenderer.material.color;
            
        }
        

        

        //myRenderer.material.color = anotherColor;
    }
}
