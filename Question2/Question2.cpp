#include <iostream>
#include <vector>

struct Vertex {
    float x, y, z;
    Vertex(float xVal, float yVal, float zVal) : x(xVal), y(yVal), z(zVal) {}
};

struct Color {
    float r, g, b;
    Color(float rVal, float gVal, float bVal) : r(rVal), g(gVal), b(bVal) {}
};

struct Normal {
    float x, y, z;
    Normal(float xVal, float yVal, float zVal) : x(xVal), y(yVal), z(zVal) {}
};

struct Triangle {
    Vertex vertices[3];
    Color colors[3];
    Normal normal;

    Triangle(Vertex v1, Vertex v2, Vertex v3, Color c1, Color c2, Color c3, Normal n)
        : vertices{ v1, v2, v3 }, colors{ c1, c2, c3 }, normal(n) {}
};

class TriangleList {
private:
    std::vector<Triangle> triangles;

public:
    void addTriangle(const Triangle& triangle) {
        triangles.push_back(triangle);
    }

    void printTriangles() const {
        int count = 1;
        for (const Triangle& t : triangles) {
            std::cout << "Triangle " << count << ":\n";
            for (int i = 0; i < 3; ++i) {
                std::cout << "  Vertex " << i + 1 << ": ("
                    << t.vertices[i].x << ", "
                    << t.vertices[i].y << ", "
                    << t.vertices[i].z << ")\n";
                std::cout << "  Color " << i + 1 << ": ("
                    << t.colors[i].r << ", "
                    << t.colors[i].g << ", "
                    << t.colors[i].b << ")\n";
            }
            std::cout << "  Normal: ("
                << t.normal.x << ", "
                << t.normal.y << ", "
                << t.normal.z << ")\n\n";
            count++;
        }
    }
};

int main() {
    TriangleList triangleList;

    Triangle triangle1(
        Vertex(0, 0, 0), Vertex(1, 0, 0), Vertex(0, 1, 0),
        Color(1, 0, 0), Color(0, 1, 0), Color(0, 0, 1),
        Normal(0, 0, 1)
    );

    triangleList.addTriangle(triangle1);

    triangleList.printTriangles();

    return 0;
}
