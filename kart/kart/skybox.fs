#version 330 core
in vec2 TexCoords;

out vec4 color;

in vec3 TexCoords;

uniform samplerCube skybox;

void main()
{
    color =  texture(skybox, TexCoords);
}