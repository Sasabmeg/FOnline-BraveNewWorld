//
// FOnline data input/output structures
// Included to other effects
//


// 3D structures
struct AppToVs_3D
{
	float4 Position     : POSITION;
	float3 Normal       : NORMAL;
	float2 TexCoord     : TEXCOORD;
};

struct AppToVs_3DTangent
{
	float4 Position     : POSITION;
	float3 Normal       : NORMAL;
	float2 TexCoord     : TEXCOORD;
	float3 Tangent      : TANGENT;
	float3 Binormal     : BINORMAL;
};

struct AppToVs_3DSkinned
{
	float4 Position     : POSITION;
	float4 BlendWeights : BLENDWEIGHT;
	float4 BlendIndices : BLENDINDICES;
	float3 Normal       : NORMAL;
	float2 TexCoord     : TEXCOORD;
};

struct AppToVs_3DSkinnedTangent
{
	float4 Position     : POSITION;
	float4 BlendWeights : BLENDWEIGHT;
	float4 BlendIndices : BLENDINDICES;
	float3 Normal       : NORMAL;
	float2 TexCoord     : TEXCOORD;
	float3 Tangent      : TANGENT;
	float3 Binormal     : BINORMAL;
};

struct VsToPs_3D
{
	float4 Position     : POSITION;
	float4 Diffuse      : COLOR;
	float2 TexCoord     : TEXCOORD;
};

struct VsToPs_3DTangent
{
	float4 Position     : POSITION;
	float2 TexCoord     : TEXCOORD0;
	float3 LightDir     : TEXCOORD1; 
};

// 2D structures
struct AppToVsToPs_2D
{
	float4 Position     : POSITION;
	float4 Diffuse      : COLOR;
	float2 TexCoord     : TEXCOORD;
};

struct AppToVsToPs_2DEgg
{
	float4 Position     : POSITION;
	float4 Diffuse      : COLOR;
	float2 TexCoord     : TEXCOORD0;
	float2 TexEggCoord  : TEXCOORD1;
};

struct AppToVsToPs_2DPrimitive
{
	float4 Position     : POSITION;
	float4 Diffuse      : COLOR;
};

