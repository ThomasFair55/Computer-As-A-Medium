using System.Collections;
using UnityEngine;

public class PlayerWarning : MonoBehaviour
{
    public GameObject WarningUI;
    public GameObject Zone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(TrapWarning());
    }

    IEnumerator TrapWarning()
    {
        WarningUI.SetActive(true);
        yield return new WaitForSeconds(3f);
        WarningUI.SetActive(false);
    }
}
