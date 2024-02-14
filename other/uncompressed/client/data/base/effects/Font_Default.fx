//
// FOnline default effect
// For font sprites
//

#include "IOStructures.inc"

sampler2D ColorMap;


// Vertex shader
AppToVsToPs_2D VSSimple(AppToVsToPs_2D input)
{
	// Just pass forward
	return input;
}


// Pixel shader
float4 PSSimple(AppToVsToPs_2D input) : COLOR
{
	float4 output;

	// Sample
	float4 texColor = tex2D(ColorMap, input.TexCoord);
	output.rgb = (texColor.rgb * input.Diffuse.rgb) * 2;
	output.a = texColor.a * input.Diffuse.a;

	return output;
}


// Techniques
technique Simple
{
	pass p0
	{
		VertexShader = (compile vs_2_0 VSSimple());
		PixelShader  = (compile ps_2_0 PSSimple());
	}
}

