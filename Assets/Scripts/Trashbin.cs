using UnityEngine;

public class Trashbin : MonoBehaviour
{
    public int itemCount;

    void Update() {
        
    }

    
    public void Reset()
    {
        // 원래 위치로 이동
        itemCount = 0;
    }
}