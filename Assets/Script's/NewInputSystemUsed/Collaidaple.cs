using UnityEngine;
using UnityEngine.UI;

public class Collaidaple : MonoBehaviour
{
    //creator name--bhuvaneshwaran.p, this one for IDZ private Lmt., Date (06/01/2023) 
    [SerializeField]
    private Text Score;
    private int scorenumber;
    [SerializeField]
    private GameObject VictoryText, Transprent;
   

    // Update is called once per frame
    void Update()
    {
        if (scorenumber >= 4)
        {
            VictoryText.SetActive(true);
            Transprent.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            //when it's collad (destroy) and it will show the score
            scorenumber++;
            Score.text = scorenumber.ToString();
            
            Destroy(collision.gameObject);
        }
    }
}
