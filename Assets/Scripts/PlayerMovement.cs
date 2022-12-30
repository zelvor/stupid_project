using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue;
    private void Update(){
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        float halfScreenWidth = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreenWidth) / halfScreenWidth;
        float finalXPos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);
        playerTransform.localPosition = new Vector3(finalXPos, playerTransform.localPosition.y, playerTransform.localPosition.z);

    }
}
