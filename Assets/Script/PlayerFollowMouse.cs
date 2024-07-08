using UnityEngine;

public class PlayerFollowMouse : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket h�z�
    public float minX, maxX, minY, maxY; // S�n�rlar

    void Update()
    {
        // Fare pozisyonunu al
        Vector3 mousePosition = Input.mousePosition;

        // Fare pozisyonunu d�nya koordinatlar�na �evir
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = transform.position.z; // Z eksenini sabit tut

        // Yeni pozisyonu s�n�rlar i�inde tut
        Vector3 targetPosition = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minY, maxY);

        // Player pozisyonunu g�ncelle
        transform.position = targetPosition;
    }
}
