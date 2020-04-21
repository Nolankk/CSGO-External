using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_External.Structs
{
    public struct QAngle
    {
        public float x;
        public float y;
        public float z;

        public QAngle(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    };

    public struct Vector3D
    {
        public float x;
        public float y;
        public float z;

        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3D operator *(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        }

        public static Vector3D operator /(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
        }

        public Vector3D VectorClone()
        {
            return new Vector3D(this.x, this.y, this.z);
        }
    };

    public struct Vector2D
    {
        public float x;
        public float y;

        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x - v2.x, v1.y - v2.y);
        }

        public static Vector2D operator *(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x * v2.x, v1.y * v2.y);
        }

        public static Vector2D operator /(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x / v2.x, v1.y / v2.y);
        }

        public Vector2D VectorClone()
        {
            return new Vector2D(this.x, this.y);
        }
    };
}
