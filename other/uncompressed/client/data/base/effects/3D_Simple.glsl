#version 110

#ifdef VERTEX_SHADER
uniform mat4 ProjectionMatrix;
uniform vec4 MaterialDiffuse;
uniform vec4 MaterialAmbient;
uniform mat4 WorldMatrix;

const vec3 LightDir = vec3( 0.0, 0.0, 1.0 );
const vec3 LightAmbient = vec3( 0.0 );

attribute vec4 InPosition;
attribute vec3 InNormal;
attribute vec2 InTexCoord;

varying vec4 Color;
varying vec2 TexCoord;

void main( void )
{
	// Position
	gl_Position = ProjectionMatrix * WorldMatrix * InPosition;
	
	// Normal
	mat3 m33 = mat3( WorldMatrix[ 0 ].xyz, WorldMatrix[ 1 ].xyz, WorldMatrix[ 2 ].xyz );
	vec3 normal = m33 * InNormal;
	normal = normalize( normal );
	
	// Shade
	Color.rgb = MaterialAmbient.rgb + LightAmbient;
	Color.rgb += max( 0.0, dot( normal, LightDir ) ) * MaterialDiffuse.rgb;
	Color.a = 1.0;
	
	// Pass to fragment shader
	TexCoord = InTexCoord;
}
#endif

#ifdef FRAGMENT_SHADER
uniform sampler2D ColorMap;

varying vec4 Color;
varying vec2 TexCoord;

void main( void )
{
	gl_FragColor = texture2D( ColorMap, TexCoord ) * Color;
}
#endif
