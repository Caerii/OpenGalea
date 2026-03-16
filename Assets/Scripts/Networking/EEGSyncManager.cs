// File: EEGSyncManager.cs

using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class EEGSyncManager : NetworkBehaviour
{
    public static EEGSyncManager Instance;

    [Header("EEG Sync Data")]
    public NetworkVariable<float> syncedAttentionLevel = new NetworkVariable<float>(0f, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    [Header("UI Elements")]
    public Slider remoteAttentionSlider;
    public Text remoteAttentionText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

private float lastLoggedValue = -1f;

    private void Update()
    {
         if (!IsOwner && remoteAttentionSlider != null)
    {
        remoteAttentionSlider.value = syncedAttentionLevel.Value;
    }

    if (!IsOwner && remoteAttentionText != null)
    {
        remoteAttentionText.text = $"Other Attention: {syncedAttentionLevel.Value:F2}";
    }

    if (!IsOwner && Mathf.Abs(syncedAttentionLevel.Value - lastLoggedValue) > 0.01f)
    {
        Debug.Log($"[EEG Sync] Remote attention level updated: {syncedAttentionLevel.Value:F2}");
        lastLoggedValue = syncedAttentionLevel.Value;
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

// --- Usage Example ---
// In EEG input script (e.g., from Python via LSL):
// EEGSyncManager.Instance.UpdateAttentionLevel(currentAttention);
// In UI or scene logic:
// float otherAttention = EEGSyncManager.Instance.GetRemoteAttentionLevel();

