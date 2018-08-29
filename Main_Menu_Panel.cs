using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Panel : BasePanel {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Start_Button()
    {
        GameManager.Instance.SceneLoader.LoadScene("Gameplay_Demo");
        UIManager.Instance.HidePanel<Main_Menu_Panel>();
    }

    public void Option_Button()
    {

    }

    public void Quit_Button()
    {
        Application.Quit();
    }
}
