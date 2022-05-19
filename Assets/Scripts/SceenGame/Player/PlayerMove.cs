using UnityEngine;

namespace CrazyEight
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class PlayerMove : MonoBehaviour
	{
		[SerializeField] private DynamicJoystick _jostick;

		private Rigidbody2D _rigidbody2D;
		private float _speed = 3f;
		private Vector2 _direction = Vector2.zero;


        private void Awake()
        {
			_rigidbody2D = GetComponent<Rigidbody2D>();

        }

        private void FixedUpdate()
        {
            if (_jostick.Horizontal != 0 || _jostick.Vertical != 0)
            {
                _direction.x = _jostick.Horizontal;
                _direction.y = _jostick.Vertical;
                _rigidbody2D.MovePosition(_rigidbody2D.position + _speed * Time.deltaTime * _direction);
            }
        }
    }
}
