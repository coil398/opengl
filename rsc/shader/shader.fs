#version 330 core

in vec3 FragPosition;

out vec4 FragColor;

void main() {
    FragColor = (vec4(FragPosition, 1.0) + vec4(1.0, 1.0, 1.0, 1.0)) / 2;
}
