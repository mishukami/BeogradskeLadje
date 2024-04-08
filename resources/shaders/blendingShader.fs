#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;

void main()
{
    vec4 tmp = texture(texture1, TexCoords);
    tmp.a *= 0.7;
    tmp.rgb *= 0.6;
    FragColor = tmp;

}

