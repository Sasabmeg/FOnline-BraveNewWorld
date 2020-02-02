#version 110

#ifndef SHADOW

#ifdef VERTEX_SHADER
uniform mat4  ProjectionMatrix;
uniform float BoneInfluences;
uniform vec4  MaterialDiffuse;
uniform vec4  MaterialAmbient;
uniform mat4  WorldMatrices[ 60 ];

const vec3 LightDir = vec3( 0.0, 0.0, 1.0 );
const vec3 LightAmbient = vec3( 0.0 );

attribute vec4 InPosition;
attribute vec3 InNormal;
attribute vec2 InTexCoord;
attribute vec4 InBlendWeights;
attribute vec4 InBlendIndices;

varying vec4 Color;
varying vec2 TexCoord;

void main( void )
{
	// Skinning
	vec4 weights = InBlendWeights;
	vec4 indices = InBlendIndices;
	vec4 position = vec4( 0.0 );
	vec3 normal = vec3( 0.0 );
	int boneInfluences = int( BoneInfluences );
	for( int i = 0; i < 4; i++ )
	{
		if ( i < boneInfluences )
		{
			mat4 m44 = WorldMatrices[ int( indices.x ) ];
			mat3 m33 = mat3( m44[ 0 ].xyz, m44[ 1 ].xyz, m44[ 2 ].xyz );
			float w = weights.x;
			position += m44 * InPosition * w;
			normal += m33 * InNormal * w;
			weights = weights.yzwx;
			indices = indices.yzwx;
		}
	}
	
	// Position
	gl_Position = ProjectionMatrix * position;
	
	// Normal
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

#else // SHADOW

#ifdef VERTEX_SHADER
uniform mat4  ProjectionMatrix;
uniform float BoneInfluences;
uniform mat4  WorldMatrices[ 60 ];
uniform vec3  GroundPosition;

attribute vec4 InPosition;
attribute vec2 InTexCoord;
attribute vec4 InBlendWeights;
attribute vec4 InBlendIndices;

varying vec2 TexCoord;

const float CameraAngleCos = 0.9010770213221; // cos( 25.7 )
const float CameraAngleSin = 0.4336590845875; // sin( 25.7 )
const float ShadowAngleTan = 0.2548968037538; // tan( 14.3 )

void main( void )
{
	// Skinning
	vec4 weights = InBlendWeights;
	vec4 indices = InBlendIndices;
	vec4 position = vec4( 0.0 );
	int boneInfluences = int( BoneInfluences );
	for( int i = 0; i < 4; i++ )
	{
		if ( i < boneInfluences )
		{
			mat4 m44 = WorldMatrices[ int( indices.x ) ];
			float w = weights.x;
			position += m44 * InPosition * w;
			weights = weights.yzwx;
			indices = indices.yzwx;
		}
	}
	
	// Calculate shadow position
	float d = ( position.y - GroundPosition.y ) * CameraAngleCos;
	d -= ( GroundPosition.z - position.z ) * CameraAngleSin;
	position.y -= d * CameraAngleCos;
	position.z += d * CameraAngleSin;
	d *= ShadowAngleTan;
	position.y += d * CameraAngleSin;
	position.z += d * CameraAngleCos;
	
	// Position
	gl_Position = ProjectionMatrix * position;
	
	// Pass to fragment shader
	TexCoord = InTexCoord;
}
#endif

#ifdef FRAGMENT_SHADER
uniform sampler2D ColorMap;

varying vec2 TexCoord;

void main( void )
{
	gl_FragColor.rgb = vec3( 0.0 );
	gl_FragColor.a = texture2D( ColorMap, TexCoord ).a;
}
#endif

#endif // !SHADOW
