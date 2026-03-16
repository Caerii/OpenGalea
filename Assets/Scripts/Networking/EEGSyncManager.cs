using Unity.Netcode;
using UnityEngine;

public class EEGSyncManager : NetworkBehaviour
{
    public static EEGSyncManager Instance;

    [Header("EEG Sync Data")]
    public NetworkVariable<float> syncedAttentionLevel = new NetworkVariable<float>(
        0f,
        NetworkVariableReadPermission.Everyone,
        NetworkVariableWritePermission.Owner
    );

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void UpdateAttentionLevel(float newLevel)
    {
        if (IsOwner)
        {
            syncedAttentionLevel.Value = newLevel;
        }
    }

    public float GetRemoteAttentionLevel()
    {
        return syncedAttentionLevel.Value;
    }
}

