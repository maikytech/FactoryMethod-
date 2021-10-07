using System;
using UnityEngine;


namespace PowerUps
{
    public class PowerUpFactory : MonoBehaviour
    {
        [SerializeField] private PowerUp _speedPowerUp;

        public PowerUp Create(string id)
        {
            switch (id)
            {
                case "Speed":
                    return Instantiate(_speedPowerUp);

                default:
                    throw new ArgumentOutOfRangeException(paramName: $"PowerUp with id {id} does not exist");

            }

                

            

        }
    }
}


