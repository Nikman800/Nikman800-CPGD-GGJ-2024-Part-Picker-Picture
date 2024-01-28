// ClipArtShader.shader
Shader "Custom/ClipArtShader"
{
    SubShader
    {
        Tags { "Queue" = "Overlay" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma exclude_renderers gles xbox360 ps3

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 pos : POSITION;
            };

            v2f vert(appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                return o;
            }
            ENDCG
        }
    }
}
