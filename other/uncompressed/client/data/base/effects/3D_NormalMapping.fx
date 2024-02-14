//
// FOnline default effect
// For skinned and static meshes
//

#include "IOStructures.inc"

// Samplers
texture Texture0;
texture Texture1;

sampler ColorMap = sampler_state
{
     Texture   = (Texture0);
     MinFilter = Linear;
     MagFilter = Linear;
     MipFilter = Linear;
};
sampler NormalMap = sampler_state
{
     Texture   = (Texture1);
     MinFilter = Linear;
     MagFilter = Linear;
     MipFilter = Linear;
};

// Bones per vertex, for skinned meshes
int BonesInfluences               = 2;

// Ground position
float4 GroundPosition             = {0.0f, 0.0f, 0.0f, 0.0f};

// Lighting
float3 LightDir                          = {0.0f, 0.0f,-1.0f};       // Light direction 
float4 LightDiffuse                      = {0.6f, 0.6f, 0.6f, 1.0f}; // Light diffuse color
float4 MaterialAmbient : MATERIALAMBIENT = {0.3f, 0.3f, 0.3f, 1.0f}; // Ambient color
float4 MaterialDiffuse : MATERIALDIFFUSE = {0.8f, 0.8f, 0.8f, 1.0f}; // Diffuse color

// Matrix pallette, for simple meshes used WorldMatrices[0]
static const int MaxMatrices      = 60;
float4x3 WorldMatrices[MaxMatrices] : WORLDMATRIXARRAY;
float4x4 ViewProjMatrix             : VIEWPROJECTION;

// Some useful game angles
static const float CameraAngle    = 25.7f * 3.141592654f / 180.0f;
static const float CameraAngleCos = cos(CameraAngle);
static const float CameraAngleSin = sin(CameraAngle);
static const float ShadowAngle    = 14.3f * 3.141592654f / 180.0f;
static const float ShadowAngleTan = tan(ShadowAngle);


// Vertex shader
VsToPs_3DTangent VSSimpleNormal(AppToVs_3DTangent input)
{
	VsToPs_3DTangent output = (VsToPs_3DTangent)0;

	// Calculate position
	float3 pos = mul(input.Position, WorldMatrices[0]);
	output.Position = mul(float4(pos, 1.0f), ViewProjMatrix);

	// Tangent space
	float3x3 matTBN;
	matTBN[0] = mul(input.Tangent,  WorldMatrices[0]);
	matTBN[1] = mul(input.Binormal, WorldMatrices[0]);
	matTBN[2] = mul(input.Normal,   WorldMatrices[0]);
	output.LightDir = mul(matTBN, LightDir);

	// Copy the input texture coordinate through
	output.TexCoord = input.TexCoord;

	return output;
}

VsToPs_3DTangent VSSimpleShadow(AppToVs_3DTangent input)
{
	VsToPs_3DTangent output = (VsToPs_3DTangent)0;

	// Calculate shadow position
	float3 pos = mul(input.Position, WorldMatrices[0]);
	float d = (pos.y - GroundPosition.y) * CameraAngleCos - (pos.z - GroundPosition.z) * CameraAngleSin;
	pos.y -= d * CameraAngleCos;
	pos.z += d * CameraAngleSin;
	d *= ShadowAngleTan;
	pos.y += d * CameraAngleSin;
	pos.z += d * CameraAngleCos;

	// Transform position from world space into view and then projection space
	output.Position = mul(float4(pos.xyz, 1.0f), ViewProjMatrix);

	// Copy the input texture coordinate through
	output.TexCoord = input.TexCoord;

	return output;
}

VsToPs_3DTangent VSSkinnedNormal(AppToVs_3DSkinnedTangent input, uniform int bones)
{
	VsToPs_3DTangent output = (VsToPs_3DTangent)0;
	float3      pos        = 0.0f;
	float3      normal     = 0.0f;
	float3      tangent    = 0.0f;
	float3      binormal   = 0.0f;
	float       lastWeight = 0.0f;

	// Cast the vectors to arrays for use in the for loop below
	float blendWeightsArray[4] = (float[4])input.BlendWeights;
	int   indexArray[4]        = (int[4])D3DCOLORtoUBYTE4(input.BlendIndices);

	// Calculate the pos using the "normal" weights 
	// and accumulate the weights to calculate the last weight
	for(int i = 0; i < bones-1; i++)
	{
		lastWeight = lastWeight + blendWeightsArray[i];
		pos += mul(input.Position, WorldMatrices[indexArray[i]]) * blendWeightsArray[i];
		normal += mul(input.Normal, WorldMatrices[indexArray[i]]) * blendWeightsArray[i];
		tangent += mul(input.Tangent, WorldMatrices[indexArray[i]]) * blendWeightsArray[i];
		binormal += mul(input.Binormal, WorldMatrices[indexArray[i]]) * blendWeightsArray[i];
	}
	lastWeight = 1.0f - lastWeight; 

	// Now that we have the calculated weight, add in the final influence
	pos += (mul(input.Position, WorldMatrices[indexArray[bones - 1]]) * lastWeight);
	normal += (mul(input.Normal, WorldMatrices[indexArray[bones - 1]]) * lastWeight); 

	// Transform position from world space into view and then projection space
	output.Position = mul(float4(pos.xyz, 1.0f), ViewProjMatrix);

	// Normalize normals
	normal = normalize(normal);

	// Tangent space
	float3x3 matTBN;
	matTBN[0] = mul(tangent,  WorldMatrices[0]);
	matTBN[1] = mul(binormal, WorldMatrices[0]);
	matTBN[2] = mul(normal,   WorldMatrices[0]);
	output.LightDir = mul(matTBN, LightDir);

	// Copy the input texture coordinate through
	output.TexCoord = input.TexCoord;

	return output;
}

VsToPs_3DTangent VSSkinnedShadow(AppToVs_3DSkinnedTangent input, uniform int bones)
{
	VsToPs_3DTangent output = (VsToPs_3DTangent)0;
	float3             pos        = 0.0f;
	float              lastWeight = 0.0f;

	// Cast the vectors to arrays for use in the for loop below
	float blendWeightsArray[4] = (float[4])input.BlendWeights;
	int   indexArray[4]        = (int[4])D3DCOLORtoUBYTE4(input.BlendIndices);

	// Calculate the pos using the "normal" weights 
	// and accumulate the weights to calculate the last weight
	for(int i = 0; i < bones-1; i++)
	{
		lastWeight = lastWeight + blendWeightsArray[i];
		pos += mul(input.Position, WorldMatrices[indexArray[i]]) * blendWeightsArray[i];
	}
	lastWeight = 1.0f - lastWeight;

	// Now that we have the calculated weight, add in the final influence
	pos += (mul(input.Position, WorldMatrices[indexArray[bones - 1]]) * lastWeight);

	// Calculate shadow position
	float d = (pos.y - GroundPosition.y) * CameraAngleCos - (pos.z - GroundPosition.z) * CameraAngleSin;
	pos.y -= d * CameraAngleCos;
	pos.z += d * CameraAngleSin;
	d *= ShadowAngleTan;
	pos.y += d * CameraAngleSin;
	pos.z += d * CameraAngleCos;

	// Transform position from world space into view and then projection space
	output.Position = mul(float4(pos.xyz, 1.0f), ViewProjMatrix);

	// Copy the input texture coordinate through
	output.TexCoord = input.TexCoord;

	return output;
}


// Pixel shader
float4 PSNormal(VsToPs_3DTangent input) : COLOR
{
	float4 output;

	float4 color = tex2D(ColorMap, input.TexCoord);
	float3 normal = 2.0f * tex2D(NormalMap, input.TexCoord) - 1.0f;
	float3 lightDir = normalize(input.LightDir);
	float diffuse = saturate(dot(lightDir, normal));

	output.rgb = MaterialAmbient.rgb + MaterialDiffuse.rgb * diffuse;
	output.rgb *= LightDiffuse.rgb;
	output.a = 1.0f;
	output *= color;

	return output;
}

float4 PSShadow(VsToPs_3DTangent input) : COLOR
{
	float4 output;

	// Black shadow
	output.rgb = 0.0f;

	// Transparent from texture
	output.a = tex2D(ColorMap, input.TexCoord).a;

	return output;
}


// Techniques
VertexShader VSArray[10] =
{
	compile vs_2_0 VSSimpleNormal(),
	compile vs_2_0 VSSimpleShadow(),
	compile vs_2_0 VSSkinnedNormal(1),
	compile vs_2_0 VSSkinnedNormal(2),
	compile vs_2_0 VSSkinnedNormal(3),
	compile vs_2_0 VSSkinnedNormal(4),
	compile vs_2_0 VSSkinnedShadow(1),
	compile vs_2_0 VSSkinnedShadow(2),
	compile vs_2_0 VSSkinnedShadow(3),
	compile vs_2_0 VSSkinnedShadow(4)
};

PixelShader PSArray[2] =
{
	compile ps_2_0 PSNormal(),
	compile ps_2_0 PSShadow()
};

technique Simple
{
	pass p0 { VertexShader = (VSArray[0]); PixelShader = (PSArray[0]); }
}

technique SimpleWithShadow
{
	pass p0 { VertexShader = (VSArray[1]); PixelShader = (PSArray[1]); }
	pass p1 { VertexShader = (VSArray[0]); PixelShader = (PSArray[0]); }
}

technique Skinned
{
	pass p0 { VertexShader = (VSArray[2 + BonesInfluences]);     PixelShader = (PSArray[0]); }
}

technique SkinnedWithShadow
{
	pass p0 { VertexShader = (VSArray[2 + BonesInfluences + 4]); PixelShader = (PSArray[1]); }
	pass p1 { VertexShader = (VSArray[2 + BonesInfluences]);     PixelShader = (PSArray[0]); }
}


