using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public TileRow[] rows { get; private set; }

    private void Awake()
    {
        rows = GetComponentsInChildren<TileRow>();
    }
}