

//using UnityEngine;

//public class GroundSpawner : MonoBehaviour
//{
//    public static GroundSpawner instance;
//    public GameObject[] groundPrefabs;
//    public Transform spawnPoints;

//    private int currentPrefabIndex = 0;
//    private GameObject currentGround;

//    public Transform PlayerTransform;
//    public Transform cameraTransform;

//   // public GameObject parent;

//    private PlayerController playerController;
//    private CameraMovement cameraMovement;

//    private void Awake()
//    {
//        instance = this;
//    }

//    private void Start()
//    {
//       // parent = new GameObject("GroundParent");
//        playerController = PlayerTransform.GetComponent<PlayerController>();
//        cameraMovement = cameraTransform.GetComponent<CameraMovement>();

//    }


//    private void SpawnNextGround()
//    {


//        if (currentPrefabIndex < groundPrefabs.Length)
//        {

//            playerController.playerTrailRenderer.enabled = false;
//            Destroy(currentGround);
//            GameObject randomGroundPrefab = groundPrefabs[currentPrefabIndex];
//            currentGround = Instantiate(randomGroundPrefab, spawnPoints.position, Quaternion.identity);
//            playerController.playerTrailRenderer.enabled = false;


//            playerController.ResetPlayer();
//            cameraMovement.ResetCamera();
//        }
//        else
//        {
//            Debug.Log("All levels completed!");

//        }
//    }

//    public void StartGame()
//    {

//        SpawnNextGround();
//    }

//    public void MoveToNextLevel()
//    {

//        currentPrefabIndex++;
//        SpawnNextGround();
//    }
//}
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundSpawner : MonoBehaviour
{
    public static GroundSpawner instance;
    public GameObject[] groundPrefabs;
    public Transform spawnPoint;

    private int levelIndex = 0;
    private GameObject currentGround;

    public Transform PlayerTransform;
    public Transform cameraTransform;

    private PlayerController playerController;
    private CameraMovement cameraMovement;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        playerController = PlayerTransform.GetComponent<PlayerController>();
        cameraMovement = cameraTransform.GetComponent<CameraMovement>();
      
    }

    public void StartGame()
    {
       
        levelIndex = 0;
        SpawnNextGround(levelIndex);
    }

    public void MoveToNextLevel()
    {
        levelIndex++;
        SpawnNextGround(levelIndex);
       
    }


    private void SpawnNextGround(int levelIndex)
    {
        if (levelIndex < groundPrefabs.Length)
        {
            
            playerController.playerTrailRenderer.enabled = false;
            Destroy(currentGround);
            GameObject selectedGroundPrefab = groundPrefabs[levelIndex];
            currentGround = Instantiate(selectedGroundPrefab, spawnPoint.position, Quaternion.identity);
            playerController.ResetPlayer();
            cameraMovement.ResetCamera();
        }
        else
        {
            Debug.Log("Invalid level index!");
        }
    }

    public void LoadLevel(int levelIndexes)
    {
        levelIndex = levelIndexes - 1;
        SpawnNextGround(levelIndex+1);
       
    }


}
