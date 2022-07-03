using TMPro;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro UseText;
    [SerializeField]
    private Transform Camera;
    [SerializeField]
    private float MaxUseDistance = 5f;
    [SerializeField]
    private LayerMask UseLayers;

    public AudioSource WindSound;
    public float TheDistance;

    /*    public GameObject ExtraCross;
    */
    public void OnUse()
    {
        if (Physics.Raycast(Camera.position, Camera.forward, out RaycastHit hit, MaxUseDistance, UseLayers))
        {
            if (hit.collider.TryGetComponent<Door>(out Door door))
            {
                if (door.IsOpen)
                {
                    door.Close();
                }
                else
                {
                    door.Open(transform.position);
                }
            }
        }
    }

    private void Update()
    {

        TheDistance = PlayerCasting.DistanceFromTarget;

        if (Physics.Raycast(Camera.position, Camera.forward, out RaycastHit hit, MaxUseDistance, UseLayers)
            && hit.collider.TryGetComponent<Door>(out Door door))
        {
            if (door.IsOpen && TheDistance <= 2)
            {
/*                ExtraCross.SetActive(true);
*/                UseText.SetText("Close \"E\"");
                /*WindSound.Play();*/
                  WindSound.Play();

            }
            else if (!door.IsOpen && TheDistance <= 2)
            {
/*                ExtraCross.SetActive(true);
*/                UseText.SetText("Open \"E\"");
                  WindSound.Stop();
                    
            }
            UseText.gameObject.SetActive(true);
            UseText.transform.position = hit.point - (hit.point - Camera.position).normalized * 0.01f;
            UseText.transform.rotation = Quaternion.LookRotation((hit.point - Camera.position).normalized);
        }
        else
        {
            UseText.gameObject.SetActive(false);
       
/*            ExtraCross.SetActive(false);
 *            
*/        }
    }
}