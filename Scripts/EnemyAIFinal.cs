using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//Advanced list features
using System.Linq;


public class EnemyAIFinal : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    //same value accros all instances
    public float followRange = 50;
    
    //returns count of things following the player
    public static int enemyFollowCap => _enemyFollowList.Count;
    private static List<Transform> _enemyFollowList = new List<Transform>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) > followRange)
        {
            //Finds gameObject
            _enemyFollowList.Remove(transform);
            return;
        }
        //If statement to see where we are on the list, -1 = not being on the list.
        var target = Player.position;
        if (_enemyFollowList.Count - 1 > 0)
        {
            var index = _enemyFollowList.IndexOf(transform);
            if (index > 0)
            {
                target = _enemyFollowList[index - 1].position;
            }
        }
        enemy.SetDestination(target);
        //Adding to list if not currently on the list
        if (_enemyFollowList.IndexOf(transform) == -1)
            _enemyFollowList.Add(transform);
    }
}
