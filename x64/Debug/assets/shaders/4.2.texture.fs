#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;
uniform float mix_factor;

void main()
{
	FragColor =
		mix(
			texture(texture1, TexCoord),
			texture(texture2, vec2(1.0 - TexCoord.x, TexCoord.y)),
			mix_factor); // * vec4(ourcolor, 1.0);
}