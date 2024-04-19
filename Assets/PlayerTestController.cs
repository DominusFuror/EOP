using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTestController : MonoBehaviour
{

    [SerializeField]
    float speed = 1;
    [SerializeField]
    Transform playerRoot;



    Vector2 direction;


    public void DirectionChangedListener(PlayerInput playerInput)
    {
        Debug.Log("Ev");
        direction = playerInput.actions.actionMaps[0].actions[0].ReadValue<Vector2>();
  
    }
    public void Move()
    {

        playerRoot.position +=(Vector3)direction.normalized * speed *Time.fixedDeltaTime;



    }

    private void Update()
    {

     
       Debug.Log(direction.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        Move();
    }

   
}
