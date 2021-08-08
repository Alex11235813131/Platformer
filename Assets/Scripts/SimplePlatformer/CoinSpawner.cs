using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private Transform _spot;
    private Transform[] _coinSpawnSpots;

    private void Start()
    {
        _coinSpawnSpots = new Transform[_spot.childCount];

        for (int i = 0; i < _coinSpawnSpots.Length; i++)
        {
            _coinSpawnSpots[i] = _spot.GetChild(i);
            Coin newCoin = Instantiate(_template,
                new Vector3(_coinSpawnSpots[i].transform.position.x, _coinSpawnSpots[i].transform.position.y, 0), Quaternion.identity);
        }
    } 
}
