using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int targetFPS = 30;
    SUPERCharacterAIO _aio;
    private void Awake()
    {
        _aio = GameObject.FindObjectOfType<SUPERCharacterAIO>();
        Application.targetFrameRate = targetFPS;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (Application.targetFrameRate < targetFPS)
            {
                Application.targetFrameRate = targetFPS;
            }
            else
            {
                Application.targetFrameRate = 10;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _aio.PausePlayer(PauseModes.MakeKinematic);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _aio.PausePlayer(PauseModes.FreezeInPlace);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _aio.PausePlayer(PauseModes.BlockInputOnly);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _aio.UnpausePlayer();
        }
    }
}
