Shader "Custom/HotLineEmul"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv );
				fixed4 col2 = tex2D(_MainTex, i.uv+float2(0.00025,0.00025));
                // just invert the colors
                col.rbg = col.rgb*0.99 + col2.r*0.1;
				col.rbg = col.rgb*0.99 + col2.g*0.1;
				col.rgb = col.rgb*0.99 + col2.b*0.1;
                return col;
            }
            ENDCG
        }
    }
}
