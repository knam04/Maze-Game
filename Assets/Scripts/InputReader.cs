using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{

    bool wallHit; 
    bool end;

    public Vector2 ReadInput()
    {

        float x = 0; 

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && !end)
        {
            x = -10; 
        }
 
        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && !end)
        {
            x = 10;
        }

        if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)) && !end)
        {
            x = 0; 
        }
        
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)) && !end)
        {
            x = 0; 
        }

        float y = 0; 
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && !end)
        {
            y = 10; 
        }
        else if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && !end)
        {
            y = -10;
        }
        if ((Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W)))
        {
            x = 0; 
        }
        
        if ((Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S)))
        {
            x = 0; 
        }

        if (x != 0 || y != 0)
        {
            Vector2 direction = new Vector2(x, y); 
            return direction; 
        }
        return Vector2.zero; 
    }

    


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            wallHit = true; 
        }
        
    } 

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            Debug.Log("finished!");
            end = true;
        }
    }

    public bool ReadWallHit()
    {
        return wallHit; 
    }     

    public bool ReadUndo()
    {
        return end;
    }

    public bool ReadReplay()
    {
        return (Input.GetKey(KeyCode.R) && end);
    }
    //^ (Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.Z) <-- can you use this for ctrl + z?

}
