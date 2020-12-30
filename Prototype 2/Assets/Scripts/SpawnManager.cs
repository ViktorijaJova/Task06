using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //moving of the animals
    public GameObject[] animals;
    private float spawnrangeX = 20;
    private float spawnrangeZ = 20;



    private float startdelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        //spawn random animals 
        InvokeRepeating("SpawnRandomAnimal", startdelay, spawnInterval);
    }

    void Update()
    {
    }


        void SpawnRandomAnimal()
        {

            //number of animals we have
            int animalIndex = Random.Range(0, animals.Length);

            // randomly appear
            Vector3 thespawnposition = new Vector3(Random.Range(-spawnrangeX, spawnrangeX), 0, spawnrangeZ);


            Instantiate(animals[animalIndex],
            thespawnposition,
            animals[animalIndex].transform.rotation);

        }

    
}
