using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    internal enum RenderGraphProfileId
    {
        RenderGraphClear,
        RenderGraphClearDebug,
    }

    internal static class RenderGraphProfilingSamplerExtension
    {
        public static ProfilingSampler Get(this RenderGraphProfileId samplerId)
        {
            return ProfileSamplerList<RenderGraphProfileId>.Get(samplerId);
        }
    }
}
