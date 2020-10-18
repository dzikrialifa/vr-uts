using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahHalaman : MonoBehaviour
{
    public void PindahScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
