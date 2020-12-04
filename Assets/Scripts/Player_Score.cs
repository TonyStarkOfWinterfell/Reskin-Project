using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class Player_Score : MonoBehaviour
{
    private Vector3 offscreen;
    private Vector3 characterPos;
    public GameObject character;
    public GameObject FoodTrail;
    private int FD = 0;
       
    private int Pick = 0;
    private int Drop = 0;

    public float timeLeft = 40;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public string ftag;
    public GameObject[] go;

    public Trail Trail;


    public Animator transition;
    public string scenename;


    private void Awake()
    {        
        offscreen = FoodTrail.transform.position;
        Trail = GameObject.FindObjectOfType<Trail>();
    }



    void Update()
    {
        characterPos = character.transform.position;
        timeLeft -= Time.deltaTime;
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        Trail.Counter(Pick);



        if (Pick == 1 && FD == 0)
        {
            FoodTrail.transform.position = characterPos;
            FD = 1;
        }
        else if(Pick != 1 && FD == 0)
        {
            FoodTrail.transform.position = offscreen;
        }



        if(FoodTrail.transform.position.x < character.transform.position.x - 0.8f)
        {
            FoodTrail.transform.position =  new Vector3( character.transform.position.x - 0.8f, FoodTrail.transform.position.y, FoodTrail.transform.position.z);
        }
        else if (FoodTrail.transform.position.x > character.transform.position.x + 0.8f)
        {
            FoodTrail.transform.position = new Vector3(character.transform.position.x + 0.8f, FoodTrail.transform.position.y, FoodTrail.transform.position.z);
        }





        if (FoodTrail.transform.position.y != character.transform.position.y && FD == 1)
        {
            FoodTrail.transform.position = Vector2.MoveTowards(FoodTrail.transform.position, character.transform.position, Time.deltaTime * 3.5f);
        }





        if (Drop >= 7)
        {
            StartCoroutine(LoadScene());
            
        }


        IEnumerator LoadScene()
        {
            transition.SetBool("endd",true);
            yield return new WaitForSeconds(2.5f);
            SceneManager.LoadScene(scenename);
            
        }

    }




    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Finish")
        {
            FD = 0;
            CountScore();

        }


        if (trig.gameObject.name == "Food")
        {
            ftag = trig.gameObject.tag;
            playerScore += 100;
            Pick += 1;
            


            go = GameObject.FindGameObjectsWithTag(ftag);
            switch (ftag)
            {
                case "F1":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }
                    
                    break;

                case "F2":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F3":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F4":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F5":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F6":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;

                case "F7":
                    for (var i = 0; i < go.Length; i++)
                    {
                        Destroy(go[i]);
                    }

                    break;



                default:
                    break;
            }            
        }






        



        void CountScore()
        {
            if (Pick > 0)
            {
                playerScore = playerScore + (int)(timeLeft * Pick * 5);
            }            
            Drop = Drop + Pick;
            Pick = 0;            
        }
    }

}