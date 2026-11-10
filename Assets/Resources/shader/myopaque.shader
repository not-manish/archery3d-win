Shader "Custom/MyOpaque" {
	Properties {
		_Color ("固有色", Vector) = (1,1,1,1)
		_SpecColor ("高光色", Vector) = (1,1,1,1)
		_Shininess ("高光强度", Range(0.01, 3)) = 1.6
		_Gloss ("光泽度", Range(0, 1)) = 0.7
		_Reflection ("反射度", Range(0, 1)) = 0.8
		_FrezPow ("菲涅尔强度", Range(0, 1024)) = 1024
		_FrezFalloff ("菲涅尔衰减", Range(0, 10)) = 1
		_EdgeAlpha ("边缘透明", Range(0, 1)) = 0.4
		_Metalics ("金属感强度", Range(0, 1)) = 0.5
		_Cube ("反射贴图", Cube) = "Black" {}
		_MainTex ("Diffuse(RGB) Alpha(A)", 2D) = "White" {}
		_BumpMap ("Normalmap", 2D) = "Bump" {}
		_BRDFTex ("NdotL NdotH (RGBA)", 2D) = "white" {}
		_Spec_Gloss_Reflec_Masks ("高光通道(R) 光泽通道(G) 反射通道(B)", 2D) = "White" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}