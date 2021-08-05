//Code used in video: https://www.youtube.com/watch?v=PpIkrff7bKU&ab_channel=Heer

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

  

    public void btn_change_scene(string scene_name) // https://www.youtube.com/watch?v=Gywxwvsb5CA&ab_channel=LemauDev
    {
        SceneManager.LoadScene(scene_name);
    }
  
}