#version 110

#ifdef VERTEX_SHADER
uniform mat4 ProjectionMatrix;

attribute vec2 InPosition;
attribute vec4 InColor;

varying vec4 Color;

void main( void )
{
	gl_Position = ProjectionMatrix * vec4( InPosition, 0.0, 1.0 );
	Color = InColor;
}
#endif

#ifdef FRAGMENT_SHADER
varying vec4 Color;

void main( void )
{
	gl_FragColor = Color;
    
    // Put no transparency on red and green (sight lines)
    if (gl_FragColor.r == 1.0 && gl_FragColor.g == 0.0 && gl_FragColor.b == 0.0 && gl_FragColor.a == 0.3137255162)
    {
        gl_FragColor.a = 1.0;
    }
	// FoV line
    if (gl_FragColor.r == 0.0 && gl_FragColor.g == 1.0 && gl_FragColor.b == 0.0 && gl_FragColor.a == 0.3137255162)
    {
        gl_FragColor.a = 1.0;
		gl_FragColor.r = 0.1;
        gl_FragColor.g = 0.38;
		gl_FragColor.b = 0.87;
    }
	
	    if (gl_FragColor.r == 0.0 && gl_FragColor.g == 0.0 && gl_FragColor.b == 1.0 && gl_FragColor.a == 0.3137255162)
    {
        gl_FragColor.a = 1.0;
		gl_FragColor.r = 0.95;
		gl_FragColor.g = 0.8;
		gl_FragColor.b = 0.05;
    }
    
    // Fog of war will be darker
    /*if (gl_FragColor.r == 0.0 && gl_FragColor.g == 0.0 && gl_FragColor.b == 0.0 && gl_FragColor.a < 1.0)
    {
        gl_FragColor.a = 0.6;
    }*/
    
    // White aura under player will be denser
    if (gl_FragColor.r == 1.0 && gl_FragColor.g == 1.0 && gl_FragColor.b == 1.0 && gl_FragColor.a < 1.0)
    {
        //gl_FragColor.a = 0.00;
		gl_FragColor.r = 1.0;
        gl_FragColor.g = 0.81;
		gl_FragColor.b = 0.5;
		
    }
}
#endif
