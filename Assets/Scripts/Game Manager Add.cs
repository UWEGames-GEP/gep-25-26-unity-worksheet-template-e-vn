using UnityEngine;

public class GameManagerAdd : MonoBehaviour
{
    public enum GameState
    {
        GAMEPLAY,
        PAUSE
    }

    public GameState state;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameState.GAMEPLAY;   
    }

    // Update is called once per frame
    void Update()
    {
        //Checking current gamestate
        if (state == GameState.GAMEPLAY)
        {
            //Toggle state over return key
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.PAUSE;
            }
        }
        else if (state == GameState.PAUSE)
        {
            //Toggle state over the return key
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.GAMEPLAY;
            }

        }
    }


}
