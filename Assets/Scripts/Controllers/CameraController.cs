using UnityEngine;

namespace PlatformerMVC
{

    public class CameraController 
    {
        private float x;
        private float y;

        private float offsetX = 0f;
        private float offsetY = 0f;

        private float camSpeed = 1000;

        private Transform _playerTransform;
        private Transform _mCamTransform;

        public CameraController(Transform _player, Transform _camera)
        {
            _playerTransform = _player;
            _mCamTransform = _camera;
        }

        public void Update()
        {
            x = _playerTransform.position.x;
            y = _playerTransform.position.y;

            _mCamTransform.position = Vector3.Lerp(_mCamTransform.position,
                                        new Vector3(x + offsetX, y + offsetY, _mCamTransform.position.z),
                                        Time.deltaTime * camSpeed);
        }
    }
}