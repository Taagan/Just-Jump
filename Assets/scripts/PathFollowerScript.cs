using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PathFollowerScript : MonoBehaviour
{
   public Transform pathParent;
    int index;
    Transform targetPoint;
    float speed = MovementPlayer.speedCopy;
    float decimalOfWayThere;
    float speedFactor;
    // Start is called before the first frame update
    void Awake()
    {
        speed = MovementPlayer.speedCopy;
        speedFactor = 1;
        index = 0;
        targetPoint = pathParent.GetChild(index);
        transform.position = targetPoint.transform.position;
        SetNextPath(targetPoint.position, pathParent.GetChild(index + 1).position);
    }

    void FixedUpdate()
    {
        speed = MovementPlayer.speedCopy;

        decimalOfWayThere += Time.deltaTime * speed * speedFactor;
        if (decimalOfWayThere >= 1.0f)
        {
            index++;
            targetPoint = pathParent.GetChild(index);
            decimalOfWayThere -= 1.0f;
            SetNextPath(targetPoint.position, pathParent.GetChild(index + 1).position);
        }
        GetComponent<Rigidbody2D>().position = Vector3.Lerp(targetPoint.position, pathParent.GetChild(index + 1).transform.position, decimalOfWayThere);
    }

    void OnDrawGizmos()
    {
        
        Vector2 from, to;

        for (int a = 0; a < pathParent.childCount -1; a++)
        {
            from = pathParent.GetChild(a).position;
            to = pathParent.GetChild((a + 1 /* % pathParent.childCount*/)).position; // TA BORT KOMMENTAR FÖR LOOPADE PATHS, aka sista punkten connectar till start punkten igen.
            Gizmos.color = new Color(1, 0, 0);
            Gizmos.DrawLine(from, to);
        }
    }


    ////Update is called once per frame
    //    void FixedUpdate()
    //    {
    //        //transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

    //        //if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
    //        //{
    //        //        index++;
    //        //        //index %= pathParent.childCount;
    //        //        targetPoint = pathParent.GetChild(index);
    //        //}
    //    }

       public void SetNextPath(Vector2 currentLocation, Vector2 TargetLocation)
       {
        float distance = (currentLocation - TargetLocation).magnitude;
        speedFactor = (1.0f / distance);
       }
}


