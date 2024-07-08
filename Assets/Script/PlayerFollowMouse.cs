using UnityEngine;

public class PlayerFollowMouse : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hýzý
    public float minX, maxX, minY, maxY; // Sýnýrlar

    void Update()
    {
        // Fare pozisyonunu al
        Vector3 mousePosition = Input.mousePosition;

        // Fare pozisyonunu dünya koordinatlarýna çevir
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = transform.position.z; // Z eksenini sabit tut

        // Yeni pozisyonu sýnýrlar içinde tut
        Vector3 targetPosition = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minY, maxY);

        // Player pozisyonunu güncelle
        transform.position = targetPosition;
    }
}
