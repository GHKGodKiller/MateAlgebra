using UnityEngine;

public class Algebra : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;

    void Start()
    {
        Debug.Log("Hola mensos");
        Vector3 norm = Normalizar(target1.transform.position);
        Debug.Log(norm);

        // Calculamos y mostramos el producto punto
        float dotProd = DotProduct(target1.transform.position, target2.transform.position);
        Debug.Log("Producto punto: " + dotProd);
    }

    void Update()
    {
        float dist = Distance(target1.transform.position, target2.transform.position);
    }

    public float Distance(Vector3 pos1, Vector3 pos2)
    {
        float x = pos1.x - pos2.x;
        float y = pos1.y - pos2.y;
        float z = pos1.z - pos2.z;

        float x2 = x * x;
        float y2 = y * y;
        float z2 = z * z;

        float sum = x2 + y2 + z2;

        float sqrt = Mathf.Sqrt(sum);
        return sqrt;
    }

    public Vector3 Normalizar(Vector3 pos)
    {
        float x = pos.x * pos.x;
        float y = pos.y * pos.y;
        float z = pos.z * pos.z;

        float sum = x + y + z;
        float sqrt = Mathf.Sqrt(sum);

        float xn = pos.x / sqrt;
        float yn = pos.y / sqrt;
        float zn = pos.z / sqrt;

        Vector3 norm = new Vector3(xn, yn, zn);

        return norm;
    }

    // Método para calcular el producto punto
    public float DotProduct(Vector3 pos1, Vector3 pos2)
    {
        float dot = (pos1.x * pos2.x) + (pos1.y * pos2.y) + (pos1.z * pos2.z);
        return dot;
    }
}