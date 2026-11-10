Shader "Archery3D/Gem" {
	Properties {
		_MainColor ("MainColor", Vector) = (0.3607843,0,0.4627451,1)
		_Specular_Color ("Specular_Color", Vector) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Vector) = (0.2078431,0.03137255,0.1921569,1)
		_Glossiness ("Glossiness", Range(0, 1)) = 0
		_BuGuangColor ("Bu Guang Color", Vector) = (1,0.3098039,0.9647059,1)
		_BuGuangFanWei ("Bu Guang Fan Wei", Range(0, 3)) = 3
		_LightPos ("Light Pos.", Vector) = (4,10,6,0)
		_CamPos ("Cam Pos.", Vector) = (0,0,0,0)
		_BuGuangPos ("Bu Guang Pos.", Vector) = (-0.5,-1.3,0.7,0)
		_Steps ("Steps", Float) = 10
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Mobile/Diffuse"
	//CustomEditor "ShaderForgeMaterialInspector"
}