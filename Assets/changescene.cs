using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] GameObject Join;
    [SerializeField] GameObject Menu;

    // Start is called before the first frame update
    public void pressed()
    {
        StartCoroutine(WaitAndShow());
    }

    IEnumerator WaitAndShow()
    {
        yield return new WaitForSeconds(1);
        Join.SetActive(true);
        Menu.SetActive(false);
    }
}

