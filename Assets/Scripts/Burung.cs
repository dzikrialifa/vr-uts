using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Burung : MonoBehaviour
{
    public void PindahBurung(string scene)
    {
        SceneManager.LoadScene(scene);
    }


}
