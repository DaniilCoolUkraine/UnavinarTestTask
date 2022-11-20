using UnityEngine;

public class PlayerRotate : MonoBehaviour
{

    private Vector2 _startTouchPosition;
    private Vector2 _endTouchPosition;
    
    void Update()
    {
        if (Input.touchCount == 0)
            return;

        if (Input.GetTouch(0).phase == TouchPhase.Began)
            _startTouchPosition = Input.GetTouch(0).position;
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            _endTouchPosition = Input.GetTouch(0).position;
            
            if (_endTouchPosition.x > _startTouchPosition.x)
                TurnRight();
            if (_endTouchPosition.x < _startTouchPosition.x)
                TurnLeft();
        }
    }

    private void TurnLeft()
    {
        float _rotationY = transform.rotation.y;
        transform.Rotate(new Vector3(0, _rotationY+90, 0));
    }

    private void TurnRight()
    {
        float _rotationY = transform.rotation.y;
        transform.Rotate(new Vector3(0, _rotationY-90, 0));
    }
}
