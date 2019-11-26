using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour
{
    private int score = 0;

    /*public delegate void ScorePointsAction();
    public static ScorePointsAction OnScorePoints;*/

    public class PointsEvent : UnityEvent<int> { }
    public PointsEvent OnScorePoints;
    

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Medallion")
        {
            Destroy(other.gameObject);
            OnScorePoints.Invoke(1);
        }
    }
}
