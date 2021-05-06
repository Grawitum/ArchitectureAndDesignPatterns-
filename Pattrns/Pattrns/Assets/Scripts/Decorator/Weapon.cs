using UnityEngine;

namespace Asteroids.Decorator
{
    internal class Weapon : IFire
    {
        private Transform _barrelPosition;
        private Transform _barrelPositionStandart;

        private IAmmunition _bullet;
        private float _force;
        private AudioClip _audioClip;
        private AudioClip _audioClipDefolt;

        private readonly AudioSource _audioSource;
        private float _audioSourseDefoltVolume;

        public Weapon(IAmmunition bullet, Transform barrelPosition, float force, AudioSource audioSource, AudioClip audioClip)
        {
            _bullet = bullet;
            _barrelPosition = barrelPosition;
            _barrelPositionStandart = barrelPosition;
            _force = force;
            _audioSource = audioSource;
            _audioSourseDefoltVolume = _audioSource.volume;
            _audioClip = audioClip;
            _audioClipDefolt = audioClip;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBarrelPositionDefolt()
        {
            _barrelPosition = _barrelPositionStandart;
        }

        public void SetAudioSourceVolumeDefolt()
        {
            _audioSource.volume = _audioSourseDefoltVolume;
        }

        public void SetAudioClipDefolt()
        {
            _audioClip = _audioClipDefolt;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            _audioClip = audioClip;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
