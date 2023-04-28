using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/Aurora Render Pipeline")]
public class AuroraRenderPipelineAsset : RenderPipelineAsset
{
    //启用合批
    [SerializeField] private bool useDynamicBatching = true, 
        useGPUInstancing = true, 
        useSRPBatcher = true,
        useLightsPerObject = true;
    //后处理配置
    [SerializeField] PostFXSettings postFXSettings = default;
    //Shadow Map配置
    [SerializeField] private ShadowSettings shadows = default;
    //重写创建实际RenderPipline的函数
    protected override RenderPipeline CreatePipeline() 
    {
        //暂时返回null
        return new AuroraRenderPipeline(useDynamicBatching, useGPUInstancing, 
            useSRPBatcher, useLightsPerObject, 
            shadows, postFXSettings);
    }
}
