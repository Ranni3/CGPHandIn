using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string sceneName;
    public int RobotCount = 0;
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.tag != "Player") return;
        if (EnemyAIFinal.enemyFollowCap < RobotCount) return;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
