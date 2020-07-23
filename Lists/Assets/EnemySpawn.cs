using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float speed = 1.0f;
    private int enemyIndex = 0;
    public List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        Debug.Log(enemies.Count);
        StartCoroutine(GenerateEnemy());
    }
    IEnumerator GenerateEnemy()
    {
        while (true)
        {
            Debug.Log(enemyIndex);
            if (enemyIndex >= enemies.Count - 1)
            {
                enemyIndex = 0;
            }
            else
            {
                enemyIndex++;
            }
            // get a reference to the next enemy
            GameObject currEnemy = enemies[enemyIndex];
            // set it to a random color
            currEnemy.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            // place on the plane in a random place
            Instantiate(currEnemy, new Vector3(Random.Range(0.0f, 3.0f + enemyIndex), 1, 0), Quaternion.identity);
            yield return new WaitForSeconds(speed);
        }
    }
}
