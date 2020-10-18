using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class deployMushrooms : MonoBehaviour
{
    public GameObject magicPrefab;
    public GameObject trufflePrefab;
    public GameObject normalPrefab;
    public GameObject shiitakePrefab;
    private Vector2 screenBounds; 
    public float spawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); //for spawning within the screen
        StartCoroutine(spawn());
    }
    private void spawnM1()
    {
        GameObject m1 = Instantiate(normalPrefab) as GameObject;
        m1.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnM2()
    {
        GameObject m2 = Instantiate(shiitakePrefab) as GameObject;
        m2.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnM3()
    {
        GameObject m3 = Instantiate(trufflePrefab) as GameObject;
        m3.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnM4()
    {
        GameObject m4 = Instantiate(magicPrefab) as GameObject;
        m4.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnM1();
            yield return new WaitForSeconds(spawnTime);
            spawnM2();
            yield return new WaitForSeconds(spawnTime);
            spawnM3();
            yield return new WaitForSeconds(spawnTime);
            spawnM4();
            spawnTime++;
        }
    }
}
