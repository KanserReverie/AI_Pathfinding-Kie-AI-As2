using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsMoving : MonoBehaviour
{
    public float moveSpeed = 12;
    private Vector3 _moveDir;
    private CharacterController _charC;
    // Start is called before the first frame update
    [SerializeField] private int moveWait = 6;
    void Start()
    {
        _charC = GetComponent<CharacterController>();
        StartCoroutine(MoveNow());
    }
    private void Update()
    {
        _charC.Move(_moveDir * Time.deltaTime);
    }

    private IEnumerator MoveNow()
    {

        while (true)
        {
            yield return new WaitForSeconds(moveWait);
            
            float x = 4;
            while (x > 0)
            {
                _moveDir = transform.TransformDirection(0,1,0) * moveSpeed;
                x -= Time.deltaTime;
            }

            yield return new WaitForSeconds(0.6f);

            x = 4;
            while (x > 0)
            {
                _moveDir = transform.TransformDirection(0, 0, 0) * 0;
                x -= Time.deltaTime;
            }

            yield return new WaitForSeconds(14);
            x = 4;
            while (x > 0)
            {
                _moveDir = transform.TransformDirection(0, 1, 0) * -moveSpeed;
                x -= Time.deltaTime;
            }

            yield return new WaitForSeconds(moveWait);
            // Resets time.
            moveWait = Random.Range(4, 6);
        }
    }
}
