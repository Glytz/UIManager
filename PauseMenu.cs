using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : BasePanel  {
    private float _oldTimeScale = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void ShowPanel()
    {
        base.ShowPanel();
        Time.timeScale = 0;
        var playerController = GameManager.Instance.PlayerController;
        if (playerController)
            GameManager.Instance.PlayerController.Pause = true;
    }

    public override void HidePanel()
    {
        base.HidePanel();
        var playerController = GameManager.Instance.PlayerController;
        if (playerController)
            GameManager.Instance.PlayerController.Pause = false;
        Time.timeScale = 1;

    }

    public void Resume_Button()
    {   
        Time.timeScale = 1;
        this.HidePanel();
    }

    public void Option_Button()
    {

    }

    public void Quit_Button()
    {
        UIManager.Instance.HideAllPanels();
        GameManager.Instance.SceneLoader.LoadScene("Gym_Main_Menu");
        UIManager.Instance.ShowPanel<Main_Menu_Panel>();
    }
}
