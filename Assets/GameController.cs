using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform roof;
    public Vector3 roofOffset;

    public Transform[] walls;

    public List<Vector3> wallPositions = new List<Vector3>();

    // Start is called before the first frame update
    void Start() 
    {
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                Instantiate(roof, roofOffset + new Vector3(i * 10, 5.7f, j * 10), Quaternion.identity);
            }
        }

        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                int open_side = Random.Range(1, 5);
                if (j == 9)
                {
                    Instantiate(walls[0], roofOffset + new Vector3(i * 10, 2, (j * 10) + 5), Quaternion.identity);
                    wallPositions.Add(roofOffset + new Vector3(i * 10, 2, (j * 10) + 5));
                }
                else
                {
                    int wallIndex = Random.Range(0, walls.Length);
                    if(wallIndex != 2 && open_side != 1)
                    {
                        if (!wallPositions.Contains(roofOffset + new Vector3(i * 10, 2, (j * 10) + 5.5f))) 
                        {
                            Instantiate(walls[wallIndex], roofOffset + new Vector3(i * 10, 2, (j * 10) + 5), Quaternion.identity);
                            wallPositions.Add(roofOffset + new Vector3(i * 10, 2, (j * 10) + 5));
                        }
                    }
                }

                if (j == 0)
                {
                    Instantiate(walls[0], roofOffset + new Vector3(i * 10, 2, (j * 10) - 4.5f), Quaternion.identity);
                    wallPositions.Add(roofOffset + new Vector3(i * 10, 2, (j * 10) - 4.5f));
                }
                else
                {
                    int wallIndex = Random.Range(0, walls.Length);
                    if (wallIndex != 2 && open_side != 2)
                    {
                        if (!wallPositions.Contains(roofOffset + new Vector3(i * 10, 2, (j * 10) - 5f)))
                        {
                            Instantiate(walls[wallIndex], roofOffset + new Vector3(i * 10, 2, (j * 10) - 4.5f), Quaternion.identity);
                            wallPositions.Add(roofOffset + new Vector3(i * 10, 2, (j * 10) - 4.5f));
                        }
                    }
                }


                if (i == 9)
                {
                    Instantiate(walls[0], roofOffset + new Vector3((i * 10) + 5f, 2, j * 10), Quaternion.Euler(0, 90, 0));
                    wallPositions.Add(roofOffset + new Vector3((i * 10) + 5f, 2, j * 10));
                }
                else
                {
                    int wallIndex = Random.Range(0, walls.Length);
                    if (wallIndex != 2 && open_side != 3)
                    {
                        if (!wallPositions.Contains(roofOffset + new Vector3((i * 10) + 5.5f, 2, j * 10)))
                        {
                            Instantiate(walls[wallIndex], roofOffset + new Vector3((i * 10) + 5f, 2, j * 10), Quaternion.Euler(0, 90, 0));
                            wallPositions.Add(roofOffset + new Vector3((i * 10) + 5f, 2, j * 10));
                        }
                    }
                }

                if (i == 0)
                {
                    Instantiate(walls[0], roofOffset + new Vector3((i * 10) - 4.5f, 2, j * 10), Quaternion.Euler(0, 90, 0));
                    wallPositions.Add(roofOffset + new Vector3((i * 10) - 4.5f, 2, j * 10));
                }
                else {
                    int wallIndex = Random.Range(0, walls.Length);
                    if (wallIndex != 2 && open_side != 4)
                    {
                        if (!wallPositions.Contains(roofOffset + new Vector3((i * 10) - 5f, 2, j * 10)))
                        {
                            Instantiate(walls[wallIndex], roofOffset + new Vector3((i * 10) - 4.5f, 2, j * 10), Quaternion.Euler(0, 90, 0));
                            wallPositions.Add(roofOffset + new Vector3((i * 10) - 4.5f, 2, j * 10));
                        }
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
